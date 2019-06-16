﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BestDeal.Migrations
{
    public partial class neka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Tip",
            columns: new[] { "idTipa", "Ime" },
            values: new object[,]
            {
                    { 1, "Laptopi" },
                    { 2, "Mobiteli" },
                    { 3, "Računari" },
                    { 4, "Računarska oprema" }
            });

            migrationBuilder.InsertData(
                table: "Artikal",
                columns: new[] { "IdArtikla", "CijenaArtikla", "DetaljniOpis", "KratkiOpis", "NazivArtikla", "TipArtiklaidTipa", "URLMaleSlike1", "URLSlike1", "tipNaziv" },
                values: new object[,]
                {
                    { 1, 700.0, "Povežite se sa cijenjenim HP 250 notebook računarima. Završajite poslovne zadatke sa Intel® tehnologijom, osnovnim alatima za saradnju koji su učitani na HP 250. Izdržljiva šasija pomaže zaštiti laptopa od strogosti dana.", "Vrhunski laptop za prosječnog korisnika!", "HP 250 G6", 1, "https://static.toiimg.com/photo/60104728/HP-15-BS542TU-2EY84PA-Laptop-Core-i3-6th-Gen4-GB1-TBDOS.jpg", "https://images-na.ssl-images-amazon.com/images/I/81iq991JMEL._SL1500_.jpg", "Laptopi" },
                    { 31, 35.0, "Optimalna brzina i performanse za microSDHC kompatibilne uređaje, rating: class 10 (bazirano na SD 2.00 specifikaciji)", "Memorija pogodna za skladištenje digitalnog sadržaja kao što su fotografije visoke kvalitete, videi, muzika i više!", "SanDisk 32GB X2 (64GB)", 4, "https://m.media-amazon.com/images/I/811Wa0biKIL._AC_UL654_FMwebp_QL65_.jpg", "https://m.media-amazon.com/images/I/811Wa0biKIL._AC_UL654_FMwebp_QL65_.jpg", null },
                    { 30, 20.0, "Čvrsta izdržljivost koja je testirana na stiskanje preko 5,000.0,000 puta sa garantiranom izdržljivosti, 2.4GHz bežična tehnologija omogućava da istraje na velikim daljinama", "Moderni i elegantni izgled sa velikom prezisnošću!", "VicTsing MM057 2.4G Wireless Mouse", 4, "https://m.media-amazon.com/images/I/718i4jG9n2L._AC_UL654_FMwebp_QL65_.jpg", "https://m.media-amazon.com/images/I/718i4jG9n2L._AC_UL654_FMwebp_QL65_.jpg", null },
                    { 29, 40.0, "Podržano na svima platformama uključujući PlayStation 4, Xbox One, Nintendo 3DS, PSP, PC i mnogi drugi, integrisan sa mikrofonom koji transmituje bolju kvalitetu komunikacije sa svojim premium noise-canceling svojstvima", "Doživite zvuk na potpuno drugačiji način!", "BENGOO G9000 Stereo Headset", 4, "https://m.media-amazon.com/images/I/61NJQcIRM4L._AC_UL654_FMwebp_QL65_.jpg", "https://m.media-amazon.com/images/I/61NJQcIRM4L._AC_UL654_FMwebp_QL65_.jpg", null },
                    { 28, 30.0, "Radi sa svim čestim aplikacijama preko svih platformi i operativnih sistema uključujući Windows, Mac OS ili Chrome OS", "Slušalice sa naprednim digitalnim audio kontrolama!", "Logitech USB Headset", 4, "https://m.media-amazon.com/images/I/61CqYq+xwNL._AC_UL654_FMwebp_QL65_.jpg", "https://m.media-amazon.com/images/I/61CqYq+xwNL._AC_UL654_FMwebp_QL65_.jpg", null },
                    { 27, 70.0, "Integrisani dodatak za dlanove sa prilagodljivom visinom, talasasti dizajn za smanjeni stres i bolje, odnosno prirodnije tipkanje", "Ergonomični dizajn sa izdržljivom baterijom!", "Logitech MK550 Wireless Wave Keyboard", 4, "https://m.media-amazon.com/images/I/71TwPx+CT9L._AC_UL654_FMwebp_QL65_.jpg", "https://m.media-amazon.com/images/I/71TwPx+CT9L._AC_UL654_FMwebp_QL65_.jpg", null },
                    { 26, 3850.0, "Procesor: 2.7 GHz Intel Core i7, Grafika: NVIDIA GeForce GTX 980M, Memorija: 32 GB GDDR5, posjeduje 28 inčni ekran koji posjeduje PixelSense tehnologiju", "Microsoft Surface Studio je potpuno nova klasa uređaja, dizajnirana za kreativne procese!", "Microsoft Surface Studio", 3, "https://m.media-amazon.com/images/I/617dm7BrlzL._AC_UL654_FMwebp_QL65_.jpg", "https://m.media-amazon.com/images/I/617dm7BrlzL._AC_UL654_FMwebp_QL65_.jpg", null },
                    { 25, 5500.0, "Procesor: Intel Core i9-9900K, Grafika: NVIDIA GeForce RTX 2080 Ti, Memorija: CORSAIR 32GB DDR4, ugrađene RGB cijevi te ugrađeno vodeno hlađenje koje će vaše uživanje u igricama učiniti što bolje", "Uživajte u igranju igrica na maksimalnoj grafici uz ovu gaming mašinu!", "Corsair ONE i160", 3, "https://m.media-amazon.com/images/I/61ZNhGKL2WL._AC_UL654_FMwebp_QL65_.jpg", "https://m.media-amazon.com/images/I/61ZNhGKL2WL._AC_UL654_FMwebp_QL65_.jpg", null },
                    { 24, 1300.0, "Izgrađen je za igre koje traže ozbiljne performanse.Pažljivo dizajniran za nadogradnju.Brza tehnologija koja je spremna za budućnost /n Maksimalno povećajte kapacitet igranja. Velika snaga obrade sa 2. generacijom AMD Ryzen 7 procesora /n Sa 16 GB DDR4 RAM-a, ovaj gaming desktop je ugrađen sa brzim memorijama kako bi se osigurala super-pogonska izvedba i intenzivni multitasking /n Amd Radeon RX580 Grafika sa 4GB GDDR5 memorije za brži, glatkiji gameplay", "Doživite sljedeću generaciju igara sa ovom gaming računarom!", "Dell Inspiron Gaming PC", 3, "https://m.media-amazon.com/images/I/617LZ7j3uCL._AC_UL654_FMwebp_QL65_.jpg", "https://m.media-amazon.com/images/I/617LZ7j3uCL._AC_UL654_FMwebp_QL65_.jpg", null },
                    { 23, 800.0, "8th Generation Intel Core i3-8100 Processor (3.6GHz) /n 8GB DDR4 2666MHz RAM Memory & 16GB Intel Optane Memory /n 1TB 7200RPM SATA Hard Drive & 8X DVD-Writer Double-Layer Drive (DVD-RW) /n 802.11ac WiFi, Gigabit Ethernet LAN & Bluetooth 5.0. Maximum Power Supply Wattage - 300 W /n 1 - USB 3.1 Type C Gen 2 port (up to 10 Gbps), 1 - USB 3.1 Gen 2 Port, 1 - USB 3.1 Gen 1 Port, 4 - USB 2.0 Ports & 2 - HDMI Ports & 1 - VGA Port", "Ovaj računar je solidan performer čija cijena će iznenaditi prave poznavaoce hardvera!", "Acer Aspire TC-885-ACCFLi30", 3, "https://m.media-amazon.com/images/I/61Ybzz3P25L._AC_UL654_FMwebp_QL65_.jpg", "https://m.media-amazon.com/images/I/61Ybzz3P25L._AC_UL654_FMwebp_QL65_.jpg", null },
                    { 22, 400.0, "HP 8300 Intel I5 Quad-Core 3.2 GHz Processor /n 8GB RAM, 500GB Hard Drive, DVD Optical Drive /n Operativni sitem: Windows 10 Professional", "Računar za svakodnevne potrebe!", "HP 8300 Elite", 3, "https://m.media-amazon.com/images/I/41ZLGAJEh7L._AC_UL654_FMwebp_QL65_.jpg", "https://m.media-amazon.com/images/I/41ZLGAJEh7L._AC_UL654_FMwebp_QL65_.jpg", null },
                    { 21, 1200.0, "8th Generation Intel Core i5-8250U Processor 1.6GHz (Up to 3.4GHz); Operating System Architecture: 64-bit /n 23.8 inches Full HD (1920 x 1080) Widescreen Edge-to-Edge LED Back-lit Display /n 12GB DDR4 2400MHz Memory & 1TB 5400RPM SATA Hard Drive 802.11ac Wi-Fi, Gigabit Ethernet LAN & Bluetooth 4.2LE", "All In One Desktop računar za minimalne prostore!", "Acer Aspire AIO Desktop", 3, "https://m.media-amazon.com/images/I/71YktzGiStL._AC_UL654_FMwebp_QL65_.jpg", "https://m.media-amazon.com/images/I/71YktzGiStL._AC_UL654_FMwebp_QL65_.jpg", null },
                    { 20, 1600.0, "System: Intel Core i5-9400f 2.9GHz 6-Core | Intel B360 Chipset | 8GB DDR4 | 120GB SSD | 1TB HDD | Genuine Windows 10 Home 64-bit /n Graphics: NVIDIA GeForce GTX 1660 6GB Video Card | 1x HDMI | 1x DisplayPort /n Connectivity: 6 x USB 3.1 | 2 x USB 2.0 | 1x RJ-45 Network Ethernet 10/100/1000 | 802.11AC Wi-Fi | Audio: 7.1 Channel | Gaming ", "Gaming računar koji će zasititi i one koje koji traže više!", "CyberPowerPC Xtreme", 3, "https://m.media-amazon.com/images/I/71DvG2FjM+L._AC_UL654_FMwebp_QL65_.jpg", "https://m.media-amazon.com/images/I/71DvG2FjM+L._AC_UL654_FMwebp_QL65_.jpg", null },
                    { 19, 800.0, "Rezolucija: 6.39 inches 1080 x 2340 pixels, 19.5:9 ratio (~403 ppi density) /n OS: Android 9.0 (Pie); ZUI 11 /n Procesor: Qualcomm SDM855 Snapdragon 855 (7 nm) /n GPU: Adreno 640 /n Card slot: microSD, up to 1 TB (uses shared SIM slot) /n Internal: 512 GB, 12 GB RAM or 256 GB, 8 GB RAM or 128 GB, 6/8 GB RAM /n Glavna kamera: Quad (48MP, 8MP, 16MP, 2MP) /n Prednja kamera: 32MP f/2.0 /n Baterija: 4000mAh", "Vrhunska tehnologija po pristupačnoj cijeni!", "Lenovo Z6 Pro", 2, "https://cdn2.gsmarena.com/vv/bigpic/lenovo-z6-pro.jpg", "https://cdn2.gsmarena.com/vv/bigpic/lenovo-z6-pro.jpg", null },
                    { 18, 600.0, "Rezolucija: 5.5 inches 1440 x 2560 pixels, 16:9 ratio (~534 ppi density) /n OS: Android 7.1 (Nougat), upgradable to Android 9.0 (Pie); Sense UI /n Procesor: Qualcomm MSM8998 Snapdragon 835 (10 nm) /n GPU: Adreno 540 /n Card slot: microSD, up to 1 TB (uses shared SIM slot) - dual SIM model only/n Internal: 128 GB, 6 GB RAM or 64 GB, 4 GB RAM /n Glavna kamera: Main (12MP f/1.7) /n Prednja kamera: 16MP f/2.0 /n Baterija: 3000mAh", "Ako želite da idete za kvalitetom i vrijednosti, vaš izbor je HTC!", "HTC U11", 2, "https://cdn2.gsmarena.com/vv/bigpic/htc-u11.jpg", "https://cdn2.gsmarena.com/vv/bigpic/htc-u11.jpg", null },
                    { 32, 45.0, "Udobne tipke kao i integrisani touchpad pružit će vam najbolje iskustvo, posjeduje distancu čak od 10 metara baziran na Plug-and-play dizajnu, sadrži bateriju koja traje 18 mjeseci te radi na Windows 7, 8, 10 kao i Android 5.0 i dalje te Chrome OS", "Uživajte u kontroli vašeg računara konektovanog na TV bez ikakvog napora!", "Logitech K400 Plus Wireless Touch TV Keyboard", 4, "https://m.media-amazon.com/images/I/716p8b4Y+eL._AC_UL654_FMwebp_QL65_.jpg", "https://m.media-amazon.com/images/I/716p8b4Y+eL._AC_UL654_FMwebp_QL65_.jpg", null },
                    { 17, 1800.0, "Rezolucija: 6.4 inches 1440 x 3120 pixels, 19.5:9 ratio (~538 ppi density) /n OS: Android 9.0 (Pie) /n Procesor: Qualcomm SDM855 Snapdragon 855 (7 nm) /n GPU: Adreno 640 /n Card slot: microSD, up to 1 TB (dedicated slot)/n Internal: 128 GB, 6 GB RAM /n Glavna kamera: Triple (12MP, 12MP, 16MP) /n Prednja kamera:Dual 8 MP, 5 MP /n Baterija: 4000mAh", "Budite prvi koji će doživjeti novu eru 5G mreže!", "LG V50 ThinkQ 5G", 2, "https://cdn2.gsmarena.com/vv/bigpic/lg-gv50-thinq-.jpg", "https://cdn2.gsmarena.com/vv/bigpic/lg-gv50-thinq-.jpg", null },
                    { 15, 550.0, "Rezolucija: 6.0 inches 1080 x 2520 pixels, 21:9 ratio (~457 ppi density) /n OS: Android 9.0 (Pie) /n Procesor: Qualcomm SDM630 Snapdragon 630 (14 nm) /n GPU: Adreno 508 /n Card slot: microSD, up to 1 TB (uses shared SIM slot) /n Internal: 64 GB, 3 GB RAM or 4 GB (for China only) /n Glavna kamera: Dual (13MP, 5MP) /n Prednja kamera: 8 MP /n Baterija: 2870mAh", "Upoznaj tehnologiju koja ispunjava vaše poslovne potrebe!", "Sony Xperia 10", 2, "https://cdn2.gsmarena.com/vv/bigpic/sony-xperia-10-.jpg", "https://cdn2.gsmarena.com/vv/bigpic/sony-xperia-10-.jpg", null },
                    { 14, 1100.0, "Rezolucija: 5.99 inches 1440 x 2880 pixels, 18:9 ratio (~538 ppi density) /n OS: Android 9.0 (Pie); Android One /n Procesor: Qualcomm SDM845 Snapdragon 845 (10 nm) /n GPU: Adreno 630 /n Card slot: No /n Internal: 128 GB, 6 GB RAM /n Glavna kamera: Five sensors(5x 12MP f/1.8) /n Prednja kamera: 20 MP /n Baterija: 3320mAh", "Upoznaj tehnologiju koja ispunjava vaše poslovne potrebe!", "Nokia 9 PureView", 2, "https://cdn2.gsmarena.com/vv/bigpic/nokia-9-pureview-.jpg", "https://cdn2.gsmarena.com/vv/bigpic/nokia-9-pureview-.jpg", null },
                    { 13, 1450.0, "Rezolucija: 6.67 inches 1440 x 3120 pixels, 19.5:9 ratio (~516 ppi density) /n OS: Android 9.0 (Pie); OxygenOS 9.5.7 /n Procesor: Qualcomm SDM855 Snapdragon 855 (7 nm) /n GPU: Adreno 640 /n Card slot: No /n Internal: 256 GB, 8/12 GB RAM or 128 GB, 6 GB RAM /n Glavna kamera: Triple sensors(48MP, 8MP, 16MP) /n Prednja kamera: Motorized pop-up 16 MP /n Baterija: 4000mAh", "Brzina koja nije ravna nijednom drugom!", "OnePlus 7 Pro", 2, "https://cdn2.gsmarena.com/vv/bigpic/huawei-p30-pro.jpg", "https://cdn2.gsmarena.com/vv/bigpic/huawei-p30-pro.jpg", null },
                    { 12, 1290.0, "Rezolucija: 6.47 inches 1080 x 2340 pixels, 19.5:9 ratio (~398 ppi density) /n OS: Android 9.0 (Pie); EMUI 9.1 /n Procesor: HiSilicon Kirin 980 (7 nm) /n GPU: Mali-G76 MP12 /n Card slot: NM (Nano Memory), up to 256GB (uses shared SIM slot) /n Internal: 128/256/512 GB, 8 GB RAM or 128 GB, 6 GB RAM /n Glavna kamera: Quad sensors(40MP, Periscope 8MP, 20MP, TOF 3D kamera) /n Prednja kamera: Single (32MP) /n Baterija: 4200mAh", "Spoznaj moć kamere uz Huawei P30 PRO", "Huawei P30 PRO 128GB", 2, "https://cdn2.gsmarena.com/vv/bigpic/huawei-p30-pro.jpg", "https://cdn2.gsmarena.com/vv/bigpic/huawei-p30-pro.jpg", null },
                    { 11, 1350.0, "Rezolucija: 5.8 inches 1125 x 2436 pixels, 19.5:9 ratio (~458 ppi density) /n OS: iOS 11.1.1, upgradable to iOS 12.3 /n Procesor: Apple A11 Bionic (10 nm) /n GPU: Apple GPU (three-core graphics) /n Card slot: No /n Internal: 64/256 GB, 3 GB RAM /n Glavna kamera: Dual sensor(12MP, 12MP) /n Prednja kamera: Dual (7MP, TOF 3D kamera) /n Baterija: 2716mAh", "Savršenstvo u svakom pogledu!", "Iphone X Silver 64GB", 2, "https://cdn2.gsmarena.com/vv/bigpic/apple-iphone-x.jpg", "https://cdn2.gsmarena.com/vv/bigpic/apple-iphone-x.jpg", null },
                    { 10, 1350.0, "Rezolucija: 6.4 inches 1440x3040 pixels, 19:9 ratio (~522 ppi density) /n OS: Android 9.0 (Pie) /n Procesor: Exynos 9820 (8nm) /n GPU: Mali-G76 MP12 /n Card slot: microSD, up to 1 TB (uses shared SIM slot) - dual SIM model only /n Internal: 1 TB, 12 GB RAM, 128/512 GB, 8 GB RAM /n Glavna kamera: Triple sensor(12MP, 12MP, 16MP) /n Prednja kamera: Dual (10MP, 8MP) /n Baterija: 4100mAh", "Sljedeća generacija galaxy uređaja!", "Samsung Galaxy S10 Plus 128GB", 2, "https://cdn2.gsmarena.com/vv/bigpic/samsung-galaxy-s10-plus-new.jpg", "https://cdn2.gsmarena.com/vv/bigpic/samsung-galaxy-s10-plus-new.jpg", null },
                    { 9, 8000.0, "Model procesora: i9-8950HK 2.90GHZ, 8 jezgri /n RAM: 32 GB /n SSD kapacitet (GB): 1500GB SSD /n Proizvođač graf. kartice: NVIDIA RTX 2080 /n Rezolucija: 1920x1080 144Hz refresh rate", "Laptop koji je u stanju podržati sve TripleA naslove igrica na maksimalnoj grafici!", "ASUS ROG G703GX", 1, "https://c1.neweggimages.com/NeweggImage/ProductImage/34-235-121-V30.jpg", "https://c1.neweggimages.com/NeweggImage/ProductImage/34-235-121-V30.jpg", null },
                    { 8, 3000.0, "Procesor: Intel Core i7 8750H 2.2 GHz (6 Cores) /n Memorija (RAM): 16 GB DDR4 /n Hard disk: 512 GB, SSD /n Grafička: Nvidia GeForce GTX 1050 /n Mreža: Wireless, LAN /n Ostalo: Card Reader, HDMI, USB3.1 , VGA ,Fingerprint", "Laptop koji će učiniti svaki zadatak da se sa lahkoćom riješi!", "ASUS UX580GD-BO009R", 1, "https://www.comtradeshop.com/img/products/2018-08-31/asus-zenbook-pro-ux580gd-bo009r-laptop-15-6-quot-full-hd-ips-intel-hexa-core-i7-8750h-16gb-512gb-ssd-nvme-geforce-gtx1050-4gb-gddr5-win10-pro_IGYtV_3.jpg", "https://www.comtradeshop.com/img/products/2018-08-31/asus-zenbook-pro-ux580gd-bo009r-laptop-15-6-quot-full-hd-ips-intel-hexa-core-i7-8750h-16gb-512gb-ssd-nvme-geforce-gtx1050-4gb-gddr5-win10-pro_IGYtV_3.jpg", null },
                    { 7, 1400.0, "Core i5-8265U, 4GB, 1TB, 14.0\" FHD, Intel UHD 620, FgrPr, Cam & Mic, No optical drive, WLAN + BT, Backlit Kb, 3 Cell, Ubuntu", "Laptop za Linux entuzijaste!", "Dell Vostro 5481", 1, "http://i.dell.com/sites/csimages/Video_Imagery/all/vostro-1471.jpg", "http://i.dell.com/sites/csimages/Video_Imagery/all/vostro-1471.jpg", null },
                    { 6, 700.0, "15,6 inch HD (1366×768) AG /n Pentium N5000 ( 4M, up to 2.7GHz) /n 4GB DD4 /n 1TB HDD (5400 rpm) /n DVD RW /n Intel UHD Graphics /n  4-Cell Batt (40Whr) /n Ubunt Linux 16.04, Ultra Blue", "Laptop namijenjen za svakodnevne potrebe!", "Dell Inspiron 15-3582", 1, "https://www.procomp.ba/17980-large_default/dell-inspiron-15-3582.jpg", "https://www.procomp.ba/17980-large_default/dell-inspiron-15-3582.jpg", null },
                    { 5, 1800.0, "CPU Intel Core i7 8550U (1.80 GHz up to 4.00 GHz) 8MB /n Radna memorija DDR4 8GB/n HDD SSD 256GB /n VGA Nvidia GTX1050 4GB DDR5 128 bita /n Ekran 15.6 LED full HD (1920x1080) /n Webcam, wifi, BT, HDMI, USB 3.0 x 2 /n USB-C, LAN, cardreader, osvjetljena tastatura /n Windows 10 Pro licenca 64 bita", "Entry level gaming laptop!", "ASUS FX570UD", 1, "https://images-na.ssl-images-amazon.com/images/I/81Lr70XWFWL._SX425_.jpg", "https://images-na.ssl-images-amazon.com/images/I/81Lr70XWFWL._SX425_.jpg", null },
                    { 4, 1500.0, "Procesor: Intel Core i5-7200 na 2.5GHz /n RAM: 8GB DDR3 /n SSD: 256GB /n Grafika: Intel HD Graphics 620 /n Display: 14\"FHD IPS LED", "Laptop koji će ispuniti svakodnevne zahtjeve njihovih korisnika!", "Acer Swift 5", 1, "https://www.notebookcheck.net/fileadmin/Notebooks/Acer/Swift_5_SF515-51T-70UX/4zu3_Acer_Swift_5_SF515_51T.jpg", "https://www.notebookcheck.net/fileadmin/Notebooks/Acer/Swift_5_SF515-51T-70UX/4zu3_Acer_Swift_5_SF515_51T.jpg", null },
                    { 3, 2250.0, "1.6GHz dual‑core 8th‑generation Intel Core i5 processor Turbo Boost up to 3.6GHz/n Retina display 13.3-inch (diagonal) LED-backlit display with IPS technology; 2560 - by - 1600 native resolution at 227 pixels per inch with support for millions of colors/n 8GB 2133MHz LPDDR3 memory/n 128GB SSD storage/n Intel UHD Graphics 617 Touch ID/n Force Touch trackpad/n Two Thunderbolt 3 ports/n Backlit Keyboard - US English", "Vrhunski laptop za one koji žele više!", "MacBook Air", 1, "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/5998/5998800_sd.jpg", "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/5998/5998800_sd.jpg", null },
                    { 2, 850.0, "With up to Intel Pentium® Silver processing, the IdeaPad D330 has real computing power—and all the fun and mobility of a lightweight tablet. From multitasking to connecting with friends online and streaming shows, the D330 gives you the freedom to do more, anywhere.", "Odličan izbor za putovanja!", "LENOVO IdeaPad D330", 1, "https://images-na.ssl-images-amazon.com/images/I/41FYl0JeBtL._SX425_.jpg", "https://www.wootware.co.za/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/f/x/fxpapmt2ez1.jpg", null },
                    { 16, 550.0, "Rezolucija: 6.0 inches 1080 x 2520 pixels, 21:9 ratio (~457 ppi density) /n OS: Android 9.0 (Pie) /n Procesor: Qualcomm SDM630 Snapdragon 630 (14 nm) /n GPU: Adreno 508 /n Card slot: microSD, up to 1 TB (uses shared SIM slot) /n Internal: 64 GB, 3 GB RAM or 4 GB (for China only) /n Glavna kamera: Dual (13MP, 5MP) /n Prednja kamera: 8 MP /n Baterija: 2870mAh", "Upoznaj tehnologiju koja ispunjava vaše poslovne potrebe!", "Sony Xperia 10", 2, "https://cdn2.gsmarena.com/vv/bigpic/sony-xperia-10-.jpg", "https://cdn2.gsmarena.com/vv/bigpic/sony-xperia-10-.jpg", null },
                    { 33, 100.0, "Posjeduje optički senzor od čak 16000 DPI koji pruža određivanje osjetljivosti kroz reprogramibilne tipke za igranje, do čak 19 programibilnih tipki koji omogućavaju remapiranje i dodjelu kompleksnih makro funkcija, pored toga posjeduje i Chroma RGB Color profile koji uključuje 16.8 miliona kombinacija boja", "Doživi potpunu kontrolu u svojim rukama bez obzira koju igru igrate!", "Razer Naga Trinity Gaming Mouse", 4, "https://m.media-amazon.com/images/I/81xeyiadbaL._AC_UL654_FMwebp_QL65_.jpg", "https://m.media-amazon.com/images/I/81xeyiadbaL._AC_UL654_FMwebp_QL65_.jpg", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
