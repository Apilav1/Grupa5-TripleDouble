// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
signInWidgetConfig = {
    // Enable or disable widget functionality with the following options. Some of these features require additional configuration in your Okta admin settings. Detailed information can be found here: https://github.com/okta/okta-signin-widget#okta-sign-in-widget
    // Look and feel changes:
    logo: 'http://tripledoublestudio.com/wp-content/uploads/2018/05/Triple-Double-Primary-Logo.png', // Try changing "okta.com" to other domains, like: "workday.com", "splunk.com", or "delmonte.com"
    language: 'en',                       // Try: [fr, de, es, ja, zh-CN] Full list: https://github.com/okta/okta-signin-widget#language-and-text
    i18n: {
        //Overrides default text when using English. Override other languages by adding additional sections.
        'en': {
            'primaryauth.title': 'Logiranje',   // Changes the sign in text
            'primaryauth.submit': 'Logiraj se!',  // Changes the sign in button
            'primaryauth.username.placeholder': 'Korisničko ime',
            'primaryauth.password.placeholder': 'Lozinka',
            // More e.g. [primaryauth.username.placeholder,  primaryauth.password.placeholder, needhelp, etc.].
            // Full list here: https://github.com/okta/okta-signin-widget/blob/master/packages/@okta/i18n/dist/properties/login.properties
        }
    },
    // Changes to widget functionality
    features: {
        registration: true,                 // Enable self-service registration flow
        rememberMe: true,                   // Setting to false will remove the checkbox to save username
        //multiOptionalFactorEnroll: true,  // Allow users to enroll in multiple optional factors before finishing the authentication flow.
        //selfServiceUnlock: true,          // Will enable unlock in addition to forgotten password
        //smsRecovery: true,                // Enable SMS-based account recovery
        //callRecovery: true,               // Enable voice call-based account recovery
        router: true,                       // Leave this set to true for the API demo
    },
    baseUrl: 'https://bestdealservis.azurewebsites.net',
    clientId: "0oalsbpd0ey8PIgFj356",
    redirectUri: 'https://bestdealservis.azurewebsites.net/account/login',
    authParams: {
        issuer: 'https://dev-239472.okta.com/oauth2/auslsbvpdFVkH5cEE356',
        responseType: ['token', 'id_token'],
        grantType: ['implicit', 'authorizationCode'],
        scopes: ['openid'],
    },

};

signInWidget = new OktaSignIn(signInWidgetConfig);
if (signInWidget.token.hasTokensInUrl()) {
    signInWidget.token.parseTokensFromUrl(
        function success(res) {
            // The tokens are returned in the order requested by `responseType` above
            var accessToken = res[0];
            var idToken = res[1]

            // Say hello to the person who just signed in:
            //console.log('Hello, ' + idToken.claims.email);

            // Save the tokens for later use, e.g. if the page gets refreshed:
            signInWidget.tokenManager.add('accessToken', accessToken);
            signInWidget.tokenManager.add('idToken', idToken);

            // Remove the tokens from the window location hash
            window.location.hash = '';
        },
        function error(err) {
            // handle errors as needed
            console.error(err);
        }
    );
} else {
    signInWidget.session.get(function (res) {
        // Session exists, show logged in state.
        if (res.status === 'ACTIVE') {
            console.log('Welcome back, ' + res.login);
            return;
        }
        // No session, show the login form
        signInWidget.renderEl(
            { el: '#okta-login-container' },
            function success(res) {
                // Nothing to do in this case, the widget will automatically redirect
                // the user to Okta for authentication, then back to this page if successful
            },
            function error(err) {
                // handle errors as needed
                console.error(err);
            }
        );
    });
}
function widgetSuccessCallback(res) {
    var key = '';
    if (res[0]) {
        key = Object.keys(res[0])[0];
        signInWidget.tokenManager.add(key, res[0]);
    }
    if (res[1]) {
        key = Object.keys(res[1])[0];
        signInWidget.tokenManager.add(key, res[1]);
    }
    if (res.status === 'SUCCESS') {
        var token = signInWidget.tokenManager.get(key);
        console.log("Logged in to Okta and issued token:");
        console.log(token);
        console.log("Reload this page to start over.");
        alert("Logged in! Check your developer console for details");
    }
}

function widgetErrorCallback(err) {
}

signInWidget.renderEl({ el: '#widget-container' }, widgetSuccessCallback, widgetErrorCallback);

function callMessagesApi() {
    var accessToken = signInWidget.tokenManager.get("accessToken");

    if (!accessToken) {
        return;
    }

    // Make the request using jQuery
    $.ajax({
        url: 'https://bestdealservis.azurewebsites.net/api/messages',
        headers: {
            Authorization: 'Bearer ' + accessToken.accessToken
        },
        success: function (response) {
            // Received messages!
            console.log('Messages', response);
        },
        error: function (response) {
            console.error(response);
        }
    });
    function error(err) {
        var errorEl = document.createElement('div');
        errorEl.textContent = 'Error! ' + err.message;
        document.body.insertBefore(
            errorEl,
            document.body.firstChild
        );
    }
}