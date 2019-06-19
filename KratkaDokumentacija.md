# Dokumentacija projekta

### Admin login:
- Username: admin@bestdeal.ba
- Password: Sifra1.

# Funkcionalnosti
### Registracija, login i upravljanje korisničkim računima
- ##### Korišten integrirani Identity iz ASP.NET Core uz nekoliko modifikacija
  - ###### Omogućen pregled korisničkog računa
  - ###### Jednostavna registracija i login sa spašavanjem podataka u bazu
  - ###### 2FA za veću sigurnost korisničkih računa koristeći QR kod uz bilo koji validator
  - ###### Jednostavno preuzimanje svih podataka o računu ili brisanje istog
  - ###### Email verifikacija korisničkih računa (koja zaista radi)
  - ###### Prijava preko eksternih servisa (implementiran samo Google), tako da se korisnik ne mora registrovati lokalnim računom ukoliko to ne želi, ali ako se odluči na to neće se morati uvijek prijavljivati preko Google

### Početna stranica
- ##### Prikaz glavnog menija iz shared layouta
- ##### Prikaz svih artikala kroz 'carousel' pokretnu kontrolu sa opcijom kupovine
- ##### Prikaz istaknutih artikala sa slikom, cijenom, mogućnosti kupovine te pregleda recenzija


### Admin konzola
- ##### Admin ima mogućnost dodavanja, pregleda, ažuriranja i brisanja svih vrsta artikala (potpuno perzistentno sa bazom podataka na Azure) što je realizirano kroz API kontroler i web servis
- ##### Mogućnost pregleda raznih vrsta statistika vezanih za artikle, recenzije, narudžbe i ostale elemente aplikacije
 
### Filtriranje artikala
- ##### Artikle je moguće filtrirati po postojećim tipovima kroz glavni meni aplikacije
### Dodavanje u korpu
- ##### Sve artikle je moguće dodati i obrisati iz korpe pri čemu se cijena pojedinačnih stavki i ukupna cijena automatski ažuriraju u KM te se otvara mogućnost narudžbe.

### Narudžba i plaćanje
- ##### Nakon odabira opcije za narudžbu korisnik popunjava podatke o sebi i bira između tri načina plaćanja, kartičnog, putem PayPala ili preko žiroračuna.