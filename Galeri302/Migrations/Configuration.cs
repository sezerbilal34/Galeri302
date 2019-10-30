namespace Galeri302.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Galeri302.Models.G302Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Galeri302.Models.G302Context db)
        {
            if (!db.Sehirler.Any())
            {
               db.Sehirler.Add(new Models.yCity() { Sehir = "01 Adana" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "02 Ad�yaman" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "03 Afyon " });
               db.Sehirler.Add(new Models.yCity() { Sehir = "04 A�r� " });
               db.Sehirler.Add(new Models.yCity() { Sehir = "05 Amasya" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "06 Ankara" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "07 Antalya" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "08 Artvin" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "09 Ayd�n" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "10 Bal�kesir" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "11 Bilecik" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "12 Bing�l" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "13 Bitlis" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "14 Bolu" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "15 Burdur" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "16 Bursa" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "17 �anakkale" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "18 �ank�r�" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "19 �orum" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "20 Denizli" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "21 Diyarbak�r" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "22 Edirne" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "23 Elaz��" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "24 Erzincan" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "25 Erzurum" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "26 Eski�ehir" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "27 Gaziantep" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "28 Giresun" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "29 G�m��hane" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "30 Hakkari" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "31 Hatay" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "32 Isparta" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "33 ��el(Mersi" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "34 �stanbul" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "35 �zmir" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "36 Kars" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "37 Kastamonu" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "38 Kayseri" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "39 K�rklareli" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "40 K�r�ehir" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "41 Kocaeli" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "42 Konya" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "43 K�tahya" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "44 Malatya" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "45 Manisa" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "46 K.mara�" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "47 Mardin" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "48 Mu�la" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "49 Mu�" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "50 Nev�ehir" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "51 Ni�de" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "52 Ordu" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "53 Rize" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "54 Sakarya" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "55 Samsun" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "56 Siirt" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "57 Sinop" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "58 Sivas" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "59 Tekirda�" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "60 Tokat" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "61 Trabzon" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "62 Tunceli" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "63 �anl�urfa" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "64 U�ak" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "65 Van" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "66 Yozgat" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "67 Zonguldak" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "68 Aksaray" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "69 Bayburt" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "70 Karaman" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "71 K�r�kkale" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "72 Batman" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "73 ��rnak" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "74 Bart�n" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "75 Ardahan" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "76 I�d�r" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "77 Yalova" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "78 Karab�k" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "79 Kilis" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "80 Osmaniye" });
               db.Sehirler.Add(new Models.yCity() { Sehir = "81 D�zce" });
              
          
               db.SaveChanges();
               
            }
        }
    }
}