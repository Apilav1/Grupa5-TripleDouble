using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BestDeal
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<Models.BestDealContext>();

                // auto migration
                context.Database.Migrate();

                // Seed the database.
                InitializeUserAndRoles(context);
            }
        }

        private static void InitializeUserAndRoles(Models.BestDealContext context)
        {
            // init user and roles  
        }
    }
}