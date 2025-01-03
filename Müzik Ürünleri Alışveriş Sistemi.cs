using System;
using System.Collections.Generic;
using System.Linq;

namespace Müzik_Ürünleri_Alışveriş_Sistemi
{
    public class Enstrüman
    {
        public string EnstrümanAd;
        public string EnstrümanTur;
        public double EnstrümanFiyat;

        // Yapıcı metod (constructor)
        public Enstrüman(string enstrüman_tur, string enstrüman_ad, double enstrüman_fiyat)
        {
            EnstrümanTur = enstrüman_tur;
            EnstrümanAd = enstrüman_ad;
            EnstrümanFiyat = enstrüman_fiyat;
        }
        public override string ToString()
        {
            return $"{EnstrümanAd} - Fiyat: {EnstrümanFiyat} TL";
        }
    }

    class EnstrümanYonetimi
    {
        private List<Enstrüman> Enstrümanlar;

        public EnstrümanYonetimi()
        {
            Enstrümanlar = new List<Enstrüman>
            {
                new Enstrüman("Gitar", "Fender ESC-110 Educational Series Classical NAT", 10200),
                new Enstrüman("Gitar", "IBANEZ GSR180-CM Bas Gitar", 10900),
                new Enstrüman("Gitar", "Kozmos KST-57HSS-GMN-BK 57 HSS Akçaağaç Klavye Siyah Elektro Gitar", 6900),
                new Enstrüman("Gitar", "Godin Concert Clasica II Elektro Klasik Gitar (Natural)", 52072),
                new Enstrüman("Gitar", "Yamaha C40M Klasik Gitar (Mat Natural)", 6600),

                new Enstrüman("Piyano", "Fenix FDP-1 Dijital Taşınabilir Piyano", 11319),
                new Enstrüman("Piyano", "Casio CDP-S360 88 Tuşlu Dijital Piyano (Siyah)", 17500),
                new Enstrüman("Piyano", "Fenix C-811 Taşınabilir Dijital Piyano Seti (Siyah)", 15695),
                new Enstrüman("Piyano", "Donner SE-1 Dijital Piyano (Siyah)", 20500),
                new Enstrüman("Piyano", "Peratron PA-61 61 Tuşlu Org (Adaptör ve Notalık Hediyeli)", 7118),

                new Enstrüman("Keman", "Stentor 1865/A The Messina 4/4 Keman", 4693),
                new Enstrüman("Keman", "Stentor 'thelami' 1016/C Laminate 3/4 Keman", 4693),
                new Enstrüman("Keman", "Eastar EVA-3 3/4 Keman Seti (Natural)", 4317),
                new Enstrüman("Keman", "Yamaha V5SC 3/4 Keman (Natural)", 22999),
                new Enstrüman("Keman", "Kinglos DSG 1310 DGS Series 4/4 Keman", 8722),
            };
        }

        public void EnstrümanTürleriListele(string enstrüman_tur)
        {   //.Where(e => e.EnstrümanTur.Equals(enstrüman_tur, StringComparison.OrdinalIgnoreCase)) Plaklar listesinden, EnstrümanTur özelliği enstrüman_tur değişkenine eşit olanları filtreler (büyük/küçük harf farkı gözetmeden).
            //.ToList() Filtrelenen sonuçları bir listeye dönüştür.
            var secilenEnstrümanlar = Enstrümanlar.Where(e => e.EnstrümanTur.Equals(enstrüman_tur, StringComparison.OrdinalIgnoreCase)).ToList();

            if (secilenEnstrümanlar.Count == 0)
            {
                Console.WriteLine("Bu türe ait enstrüman bulunamadı.");
                return;
            }

            Console.WriteLine($"--- {enstrüman_tur} Türündeki Enstrümanlar ---");
            for (int i = 0; i < secilenEnstrümanlar.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {secilenEnstrümanlar[i]}");
            }
        }

        public Enstrüman EnstrümanSec(string enstrüman_tur, int i)
        {
            var secilenEnstrümanlar = Enstrümanlar.Where(e => e.EnstrümanTur.Equals(enstrüman_tur, StringComparison.OrdinalIgnoreCase)).ToList();
            if (i > 0 && i <= secilenEnstrümanlar.Count)
            {
                return secilenEnstrümanlar[i - 1];
            }
            return null;
        }
    
    }


    // Plak sınıfı: Plakların temel özelliklerini içerir
    public class Plak
    {
        public string PlakAd;
        public string PlakSanatci;
        public double PlakFiyat;
        public string PlakTur;

        // Yapıcı metod (constructor)
        public Plak(string plak_ad, string plak_sanatci, double plak_fiyat, string plak_tur)
        {
            PlakAd = plak_ad;
            PlakSanatci = plak_sanatci;
            PlakFiyat = plak_fiyat;
            PlakTur = plak_tur;
        }
        public override string ToString()
        {
            return $"{PlakAd} - {PlakSanatci}, Fiyat: {PlakFiyat}TL";
        }
    }

    // Plak çalar cihazları için sınıf
    class PlakCihazi
    {
        public string PlakCihazAd { get; set; } // Cihaz adı
        public double PlakCihazFiyat { get; set; } // Cihaz fiyatı

        // Yapıcı metod (constructor)
        public PlakCihazi(string plak_cihaz_ad, double plak_cihaz_fiyat)
        {
            PlakCihazAd = plak_cihaz_ad;
            PlakCihazFiyat = plak_cihaz_fiyat;
        }
        public override string ToString()
        {
            return $"{PlakCihazAd}, Fiyat: {PlakCihazFiyat}TL";
        }
    }

    // Kullanıcı bilgilerini saklayan sınıf
    class Kullanici
    {
        private string isim;
        private string soyisim;
        private string telefon;
        private string email;

        public string Isim
        {
            get { return isim; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    isim = value;
                }
                else
                {
                    hatalar.Add("Geçersiz isim!");
                }
            }
        }
        public string Soyisim
        {
            get { return soyisim; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    soyisim = value;
                }
                else
                {
                    hatalar.Add("Geçersiz soyisim!");
                }
            }
        }
        public string Telefon
        {
            get { return telefon; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    telefon = value;
                }
                else
                {
                    hatalar.Add("Geçersiz telefon!");
                }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    email = value;
                }
                else
                {
                    hatalar.Add("Geçersiz email!");
                }
            }
        }

        // Kullanıcıdan alınacak girilenları kontrol eden metot için bir liste
        private List<string> hatalar = new List<string>();

        private void GecersizTesti()
        {
            while (hatalar.Count > 0)
            {
                // Hataları ekrana yazdır
                Console.WriteLine("Geçersiz girişler:");
                foreach (var hata in hatalar)
                {
                    Console.WriteLine(hata);
                }

                // Geçerli giriş yapana kadar tekrar sor
                hatalar.Clear(); // Hataları sıfırla
                Console.WriteLine("Lütfen bilgilerinizi yeniden girin:");

                Isim = GecerliGiris("İsim: ");
                Soyisim = GecerliGiris("Soyisim: ");
                Telefon = GecerliGiris("Telefon: ");
                Email = GecerliGiris("Email: ");
            }
        }

        // Kullanıcının geçerli giriş yapması için metot
        private string GecerliGiris(string bilgi)
        {
            string girilen;
            do
            {
                Console.Write(bilgi);
                girilen = Console.ReadLine();
            } while (string.IsNullOrEmpty(girilen));

            return girilen;
        }

        // Yapıcı metod (constructor)
        public Kullanici(string isim, string soyisim, string telefon, string email)
        {
            Isim = isim;
            Soyisim = soyisim;
            Telefon = telefon;
            Email = email;

            GecersizTesti();  // Geçersiz giriş varsa tekrar istenmesini sağla
        }
    }


    // Plak ve cihaz yönetimini sağlayan sınıf
    class PlakYonetimi
    {
        private List<Plak> plaklar; // Plak listesini saklar
        private List<PlakCihazi> cihazlar; // Cihaz listesini saklar

        // PlakYonetimi sınıfı kurucusu
        public PlakYonetimi()
        {
            // Varsayılan plaklar oluşturuluyor
            plaklar = new List<Plak>
            {
                new Plak("Bohemian Rhapsody", "Queen", 450, "Rock"),
                new Plak("Hotel California", "Eagles", 540, "Rock"),
                new Plak("Back in Black", "AC/DC", 435, "Rock"),
                new Plak("Stairway to Heaven", "Led Zeppelin", 460, "Rock"),
                new Plak("Born to Run", "Bruce Springsteen", 445, "Rock"),

                new Plak("Like a Virgin", "Madonna", 520, "Pop"),
                new Plak("Thriller", "Michael Jackson", 450, "Pop"),
                new Plak("1989", "Taylor Swift", 340, "Pop"),
                new Plak("Future Nostalgia", "Dua Lipa", 530, "Pop"),
                new Plak("Teenage Dream", "Katy Perry", 425, "Pop"),

                new Plak("The College Dropout", "Kanye West", 430, "Hiphop"),
                new Plak("To Pimp a Butterfly", "Kendrick Lamar", 340, "Hiphop"),
                new Plak("Illmatic", "Nas", 435, "Hiphop"),
                new Plak("Enter the Wu-Tang", "Wu-Tang Clan", 350, "Hiphop"),
                new Plak("The Chronic", "Dr. Dre", 445, "Hiphop"),

                new Plak("Kind of Blue", "Miles Davis", 450, "Jazz"),
                new Plak("Take Five", "Dave Brubeck", 540, "Jazz"),
                new Plak("Blue Train", "John Coltrane", 335, "Jazz"),
                new Plak("A Love Supreme", "John Coltrane", 360, "Jazz"),
                new Plak("Bitches Brew", "Miles Davis", 345, "Jazz"),

                new Plak("The Thrill is Gone", "B.B. King", 350, "Blues"),
                new Plak("Crossroad Blues", "Robert Johnson", 440, "Blues"),
                new Plak("Born Under a Bad Sign", "Albert King", 135, "Blues"),
                new Plak("Mannish Boy", "Muddy Waters", 460, "Blues"),
                new Plak("Pride and Joy", "Stevie Ray Vaughan", 545, "Blues")
            };

            // Varsayılan cihazlar oluşturuluyor
            cihazlar = new List<PlakCihazi>
            {
                new PlakCihazi("KTOOLS PERA Pikap Hoparlörlü", 3538),
                new PlakCihazi("KTOOLS LABEL Pikap Hoparlörlü", 450),
                new PlakCihazi("Midex GR-50 Nostaljik Gramofon FM Radyolu 33/45 Devir Pikap Plak Çalar Bluetooth", 10439)
            };
        }

        // Belirli bir türdeki plakları listeler
        public void PlaklariListele(string tür)// Kullanıcıdan plak tur bilgisi alınır. 12345... ile
        {
            //.Where(p => p.Tur.Equals(tur, StringComparison.OrdinalIgnoreCase)) Plaklar listesinden, Tur özelliği tur değişkenine eşit olanları filtreler (büyük/küçük harf farkı gözetmeden).
            //.ToList() Filtrelenen sonuçları bir listeye dönüştür.
            //Bu Rock, Pop, Hiphop vb. tarzında farklı türleri içeren listeden kullanıcıdan alınmış olan tür bilgisie göre seçer.
            var secilenPlaklar = plaklar.Where(p => p.PlakTur.Equals(tür, StringComparison.OrdinalIgnoreCase)).ToList();

            if (secilenPlaklar.Count == 0)
            {
                Console.WriteLine("Bu türe ait plak bulunamadı.");
                return;
            }

            Console.WriteLine($"--- {tür} Türündeki Plaklar ---");
            for (int i = 0; i < secilenPlaklar.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {secilenPlaklar[i]}"); // 1. Plak bilgisi 
            }
        }

        // Belirli bir plak seçimini döndürür
        public Plak PlakSec(string tür, int i)
        {
            var secilenPlaklar = plaklar.Where(p => p.PlakTur.Equals(tür, StringComparison.OrdinalIgnoreCase)).ToList();
            if (i > 0 && i <= secilenPlaklar.Count)
            {
                return secilenPlaklar[i - 1];
            }
            return null;
        }

        // Mevcut plak çalar cihazlarını listeler
        public void CihazlariListele()
        {
            Console.WriteLine("");
            Console.WriteLine("--- Mevcut Plak Çalar Cihazları ---");
            for (int i = 0; i < cihazlar.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cihazlar[i]}");
            }
        }

        // Belirli bir cihaz seçimini döndürür
        public PlakCihazi CihazSec(int i)
        {
            if (i > 0 && i <= cihazlar.Count)
            {
                return cihazlar[i - 1];
            }
            return null;
        }

    }

    // Ana program akışı
    class Program
    {
        static void Main(string[] args)
        {
            PlakYonetimi plakYonetimi = new PlakYonetimi(); // Plak yönetimi nesnesi oluşturuluyor
            EnstrümanYonetimi enstrumanYonetimi = new EnstrümanYonetimi();
            double toplamTutar = 0; // Toplam tutar başlangıç değeri

            Console.WriteLine("--- Müzik Ürünleri Alışveriş Sistemine Hoşgeldiniz! ---");

            // Kullanıcı bilgilerini al
            Console.Write("Lütfen isminizi girin: ");
            string isim = Console.ReadLine();

            Console.Write("Lütfen soyisminizi girin: ");
            string soyisim = Console.ReadLine();

            Console.Write("Lütfen telefon numaranızı girin: ");
            string telefon = Console.ReadLine();

            Console.Write("Lütfen email adresinizi girin: ");
            string email = Console.ReadLine();

            Kullanici kullanici = new Kullanici(isim, soyisim, telefon, email); // Kullanıcı nesnesi oluşturuluyor
            Console.WriteLine($"\nHoşgeldiniz {kullanici.Isim} {kullanici.Soyisim}!\n");

            while (true)
            {
                Console.WriteLine("--- Ana Menü ---");
                Console.WriteLine("1. Plak Satın Al");
                Console.WriteLine("2. Plak Cihazı Satın Al");
                Console.WriteLine("3. Enstrüman Satın Al");
                Console.WriteLine("4. Çıkış");
                Console.WriteLine("");
                Console.Write("Bir seçim yapınız: ");

                string anaSecim = Console.ReadLine();

                if (anaSecim == "1") // Plak Satın Alma
                {
                    while (true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("--- Plak Türleri ---");
                        Console.WriteLine("1. Rock");
                        Console.WriteLine("2. Pop");
                        Console.WriteLine("3. Hiphop");
                        Console.WriteLine("4. Jazz");
                        Console.WriteLine("5. Blues");
                        Console.WriteLine("6. Ana Menüye Dön");
                        Console.WriteLine("");
                        Console.Write("Bir tür seçiniz: ");

                        string turSecim = Console.ReadLine();

                        if (turSecim == "6") break; // Ana menüye dön

                        string tur = "";
                        if (turSecim == "1") tur = "Rock";
                        else if (turSecim == "2") tur = "Pop";
                        else if (turSecim == "3") tur = "Hiphop";
                        else if (turSecim == "4") tur = "Jazz";
                        else if (turSecim == "5") tur = "Blues";


                        if (tur == "")
                        {
                            Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyiniz.");
                            continue;
                        }

                        plakYonetimi.PlaklariListele(tur); // Seçilen türdeki plakları listele
                        Console.WriteLine("");
                        Console.Write("Satın almak istediğiniz plağın numarasını girin: ");
                        if (int.TryParse(Console.ReadLine(), out int secim))
                        {
                            var secilenPlak = plakYonetimi.PlakSec(tur, secim); // Kullanıcı seçimini al
                            if (secilenPlak != null)
                            {
                                toplamTutar += secilenPlak.PlakFiyat; // Fiyatı toplam tutara ekle
                                Console.WriteLine($"{secilenPlak.PlakAd} sepete eklendi. Toplam tutar: {toplamTutar}TL");
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz numara. Lütfen tekrar deneyiniz.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
                        }

                        Console.Write("Başka bir plak eklemek istiyor musunuz? (e/h): ");
                        string devam = Console.ReadLine();
                        if (!devam.Equals("e", StringComparison.OrdinalIgnoreCase))// Kullanici e harici bir sey girerse döngüden çık. e girerse plak türleri menüsüne dön
                        {
                            break;
                        }
                    }
                }
                else if (anaSecim == "2") // Plak Cihazı Satın Alma
                {
                    plakYonetimi.CihazlariListele(); // Mevcut cihazları listele
                    Console.WriteLine("");
                    Console.Write("Satın almak istediğiniz cihazın numarasını girin: ");
                    if (int.TryParse(Console.ReadLine(), out int cihazSecim))
                    {
                        Console.WriteLine("");
                        var secilenCihaz = plakYonetimi.CihazSec(cihazSecim); // Kullanıcı seçimini al
                        if (secilenCihaz != null)
                        {
                            toplamTutar += secilenCihaz.PlakCihazFiyat; // Fiyatı toplam tutara ekle
                            Console.WriteLine($"{secilenCihaz.PlakCihazAd} sepete eklendi. Toplam tutar: {toplamTutar}TL");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz numara. Lütfen tekrar deneyiniz.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
                    }
                }
                else if (anaSecim == "3") // Enstrüman Satın Alma
                {
                    while (true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("--- Enstrüman Türleri ---");
                        Console.WriteLine("1. Gitar");
                        Console.WriteLine("2. Piyano");
                        Console.WriteLine("3. Keman");
                        Console.WriteLine("4. Ana Menüye Dön");
                        Console.WriteLine("");
                        Console.Write("Bir tür seçiniz: ");
                        
                        string enstrumanSecim = Console.ReadLine();
                        if (enstrumanSecim == "4") break;

                        string ens_tür = "";
                        if (enstrumanSecim == "1") ens_tür = "Gitar";
                        else if (enstrumanSecim == "2") ens_tür = "Piyano";
                        else if (enstrumanSecim == "3") ens_tür = "Keman";

                        if (ens_tür == "")
                        {
                            Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyiniz.");
                            continue;
                        }

                        enstrumanYonetimi.EnstrümanTürleriListele(ens_tür); // Türdeki enstrümanları listele

                        Console.Write("Satın almak istediğiniz enstrümanın numarasını girin: ");
                        if (int.TryParse(Console.ReadLine(), out int ens_seçim)) //out burada secim değişkeninin TryParse metodu tarafından verilen değeri almasını sağlar
                        {
                            Console.WriteLine("");
                            var secilenEnstruman = enstrumanYonetimi.EnstrümanSec(ens_tür, ens_seçim);
                            if (secilenEnstruman != null)
                            {
                                toplamTutar += secilenEnstruman.EnstrümanFiyat;
                                Console.WriteLine($"{secilenEnstruman.EnstrümanAd} sepete eklendi. Toplam tutar: {toplamTutar}TL");
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz numara. Lütfen tekrar deneyiniz.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
                        }

                        Console.Write("Başka bir enstrüman eklemek istiyor musunuz? (e/h): ");
                        string devam = Console.ReadLine();
                        if (!devam.Equals("e", StringComparison.OrdinalIgnoreCase))
                        {
                            break;
                        }
                    }
                }

                else if (anaSecim == "4") // Çıkış
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Toplam tutarınız: {toplamTutar}TL İyi günler dileriz {isim} {soyisim}!");
                    break; // Programdan çıkış
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyiniz.");
                }
            }
        }
    }
}
