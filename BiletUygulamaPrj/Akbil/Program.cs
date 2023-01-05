using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Akbil
{
    /** Şehir İçi Ulaşım Ücretlendirme Kart Uygulamasaı
     * 
     **/
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Değişkenlerimizi tanımlayalım.......................
            
            double bakiye = 0, biletFiyat = 10;
            string ad, soyad, tcNo, kartNo;
          
            char anamenusecim = '0', altmenusecim = '0', gecismenusecim = '0'; 



            Console.WriteLine("           ŞEHİR İÇİ ULAŞIM UYGULAMA PROGRAMNA HOŞGELDİNİZ!");
            Console.WriteLine("------------------------------------------------------- ");
            Console.WriteLine(" Tam Bilet 10 TL' dir!");
            Console.WriteLine(" Öğrenci %75, 60 Yaş Üstü %50, Memur %25 İndirim Uygulanmaktadır. ");
            Console.WriteLine("------------------------------------------------------- ");
            Console.WriteLine();

        //Ana Menü Oluşturma..........................................
        MENU:                    
            Console.WriteLine("           Menüden Seçiminizi Yapınız");
            Console.WriteLine("------------------------------------------------------- ");
            Console.WriteLine(" 1 - TAMKART AL");
            Console.WriteLine(" 2 - ÖĞRENCİ KARTI AL");
            Console.WriteLine(" 3 - 60YAŞÜSTÜ KARTI AL");
            Console.WriteLine(" 4 - MEMUR KARTI AL");
            Console.WriteLine(" 5 - ÇIKIŞ");
            Console.WriteLine("--------------------------------------------------------- ");
            anamenusecim = Convert.ToChar(Console.ReadLine());
            
            //TAM GEÇİŞ..................................................
            if (anamenusecim == '1')
            {
                Console.WriteLine("Tam Kart Oluşturma Menusü");
                Console.Write("Adınız: ");
                ad = Convert.ToString(Console.ReadLine());
                Console.Write("Soyadınız: ");
                soyad = Convert.ToString(Console.ReadLine());
                Console.Write("TcNo: ");
                tcNo  = Convert.ToString(Console.ReadLine());
                Console.Write("Kart No: " + RandomNumber());
                Console.WriteLine();
                Console.WriteLine("............................");
                Console.WriteLine("Tam Kartınız Oluşturulmuştur!");
                Console.WriteLine("Kart Bilgileriniz:");
                Console.WriteLine("Adınız: " + ad + "  Soyadınız: " + soyad+ "  TcNo: " + tcNo + "  KartNo: " + RandomNumber());
                Console.WriteLine("Kart Kullanımı İçin Para Yüklemelisiniz");
                Console.WriteLine("............................");
                Console.WriteLine("Bakiyeniz:" + bakiye + "TL'dir.");
                Console.WriteLine();
                Console.Write("Yüklemek İstediğniz Tutarı Giriniz: ");
                double yeniBakiye = bakiye + Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Yeni Bakiyeniz: " + yeniBakiye);
            GECİS:
                Console.WriteLine();
                Console.WriteLine("1 - Kartla Geçişi Yap" +
                  " 2 - Ana Menü" + " 3 - Programı Kapat");
                gecismenusecim = Convert.ToChar(Console.ReadLine());
                if (gecismenusecim == '1')
                {
                    double oYeniFiyat = yeniBakiye - biletFiyat ;
                    double sBakiye = yeniBakiye - oYeniFiyat;
                    Console.WriteLine("TcNo: " + tcNo +" Kullanıcımız TAM ÜCRETLİ Geçiş İşleminiz Tamamlandı ");
                    Console.WriteLine("Tam Kartınızdan " + sBakiye + " Tutarı Çekilmiştir");
                    Console.WriteLine("Güncel Bakiyeniz:" + oYeniFiyat);
                }
                else if (gecismenusecim == '2')
                {
                    goto MENU;

                }
                else if (gecismenusecim == '3')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yapıldı!");
                    goto GECİS;
                }


            }
            //2tercih.......................................................
            else if (anamenusecim == '2')
            {
                Console.WriteLine("Öğrenci Kartı Oluşturma Menusü ");
                Console.Write("Adınız: ");
                ad = Convert.ToString(Console.ReadLine());
                Console.Write("Soyadınız: ");
                soyad = Convert.ToString(Console.ReadLine());
                Console.Write("TcNo: ");
                tcNo = Convert.ToString(Console.ReadLine());
                Console.Write("Kart No: " + RandomNumber());
                Console.WriteLine();
                Console.WriteLine("............................");
                Console.WriteLine("Öğrenci Kartınız Oluşturulmuştur!");
                Console.WriteLine("Kart Bilgileriniz:");
                Console.WriteLine("Adınız: " + ad + "  Soyadınız: " + soyad + "  TcNo: " + tcNo + "  KartNo: " + RandomNumber());
                Console.WriteLine("Kullanım İçin Ana Menüden Para Yüklemelisiniz");
                Console.WriteLine("............................");
                Console.WriteLine("Bakiyeniz: " + bakiye + "TL'dir.");
                Console.WriteLine();
                Console.Write("Yüklemek İstediğniz Tutarı Giriniz: ");
                double yeniBakiye = bakiye + Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Yeni Bakiyeniz: " + yeniBakiye + "TL'dir.");
            GECİS:
                Console.WriteLine();
                Console.WriteLine("1 - Kartla Geçişi Yap" +
                  " 2 - Ana Menü" + " 3 - Programı Kapat");
                gecismenusecim = Convert.ToChar(Console.ReadLine());
                if (gecismenusecim == '1')
                {
                    double oYeniFiyat = biletFiyat * 25 / 100;
                    double sBakiye = yeniBakiye - oYeniFiyat;
                    Console.WriteLine("TcNo: " + tcNo + " Kullanıcımız  Geçiş İşleminiz Tamamlandı");
                    Console.WriteLine();
                    Console.WriteLine("Öğrenci Kartınızdan " + oYeniFiyat + " Tutarı Çekilmiştir ");
                    Console.WriteLine("Güncel Bakiyeniz: " + sBakiye + "TL'dir.");
                }
                else if (gecismenusecim == '2')
                {
                    goto MENU;

                }
                else if (gecismenusecim == '3')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yapıldı!");
                    goto GECİS;
                }

            }
            //3 tercih..........................................
            else if (anamenusecim == '3')
            {
                Console.WriteLine("60 Yaş Üstü Kartı Oluşturma Menusü");
                Console.Write("Adınız: ");
                ad = Convert.ToString(Console.ReadLine());
                Console.Write("Soyadınız: ");
                soyad = Convert.ToString(Console.ReadLine());
                Console.Write("TcNo: ");
                tcNo = Convert.ToString(Console.ReadLine());
                Console.Write("Kart No: " + RandomNumber());
                Console.WriteLine();
                Console.WriteLine("............................");
                Console.WriteLine("60 Yaş Üstü Kartınız Oluşturulmuştur!");
                Console.WriteLine("Kart Bilgileriniz:");
                Console.WriteLine("Adınız: " + ad + "  Soyadınız: " + soyad + "  TcNo: " + tcNo + "  KartNo: " + RandomNumber());
                Console.WriteLine("Kullanım İçin Ana Menüden Para Yüklemelisiniz");
                Console.WriteLine("............................");
                Console.WriteLine("Bakiyeniz: " + bakiye + "TL'dir.");
                Console.WriteLine();
                Console.Write("Yüklemek İstediğniz Tutarı Giriniz: ");
                double yeniBakiye = bakiye + Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Yeni Bakiyeniz: " + yeniBakiye + "TL'dir.");
            GECİS:
                Console.WriteLine();
                Console.WriteLine("1 - Kartla Geçişi Yap" +
                  " 2 - Ana Menü" + " 3 - Programı Kapat");
                gecismenusecim = Convert.ToChar(Console.ReadLine());
                if (gecismenusecim == '1')
                {
                    double oYeniFiyat = biletFiyat * 50 / 100;
                    double sBakiye = yeniBakiye - oYeniFiyat;
                    Console.WriteLine("TcNo: " + tcNo + " Kullanıcımız  Geçiş İşleminiz Tamamlandı");
                    Console.WriteLine();
                    Console.WriteLine("Kartınızdan " + oYeniFiyat + " Tutarı Çekilmiştir ");
                    Console.WriteLine("Güncel Bakiyeniz: " + sBakiye + "TL'dir.");
                }
                else if (gecismenusecim == '2')
                {
                    goto MENU;

                }
                else if (gecismenusecim == '3')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yapıldı!");
                    goto GECİS;
                }

            }
            //4tercih....................................................
            else if (anamenusecim == '4')
            {
                Console.WriteLine("Memur Kartı Oluşturma Menusü ");
                Console.Write("Adınız: ");
                ad = Convert.ToString(Console.ReadLine());
                Console.Write("Soyadınız: ");
                soyad = Convert.ToString(Console.ReadLine());
                Console.Write("TcNo: ");
                tcNo = Convert.ToString(Console.ReadLine());
                Console.Write("Kart No: " + RandomNumber());
                Console.WriteLine();
                Console.WriteLine("............................");
                Console.WriteLine("Memur Kartınız Oluşturulmuştur!");
                Console.WriteLine("Kart Bilgileriniz:");
                Console.WriteLine("Adınız: " + ad + "  Soyadınız: " + soyad + "  TcNo: " + tcNo + "  KartNo: " + RandomNumber());
                Console.WriteLine("Kullanım İçin Ana Menüden Para Yüklemelisiniz");
                Console.WriteLine("............................");
                Console.WriteLine("Bakiyeniz: " + bakiye + "TL'dir.");
                Console.WriteLine();
                Console.Write("Yüklemek İstediğniz Tutarı Giriniz: ");
                double yeniBakiye = bakiye + Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Yeni Bakiyeniz: " + yeniBakiye + "TL'dir.");
            GECİS:
                Console.WriteLine();
                Console.WriteLine("1 - Kartla Geçişi Yap" +
                  " 2 - Ana Menü" + " 3 - Programı Kapat");
                gecismenusecim = Convert.ToChar(Console.ReadLine());
                if (gecismenusecim == '1')
                {
                    double oYeniFiyat = biletFiyat * 75 / 100;
                    double sBakiye = yeniBakiye - oYeniFiyat;
                    Console.WriteLine("TcNo: " + tcNo + " Kullanıcımız  Geçiş İşleminiz Tamamlandı");
                    Console.WriteLine();
                    Console.WriteLine("Kartınızdan " + oYeniFiyat + " Tutarı Çekilmiştir ");
                    Console.WriteLine("Güncel Bakiyeniz: " + sBakiye + "TL'dir.");
                }
                else if (gecismenusecim == '2')
                {
                    goto MENU;

                }
                else if (gecismenusecim == '3')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yapıldı!");
                    goto GECİS;
                }
         

            }
            else if (anamenusecim == '5')
            {
                Console.WriteLine("Program Sonlandırıldı!");
                Environment.Exit(0);
            }
          
            Console.ReadKey();
        }

        //Kartno için Rastgele Sayı oluşturalım....................
        public static string RandomNumber()
        {
            int basamak = 6;
            var random = new Random();
            var result = String.Empty;
            for (int i = 0; i <basamak ; i++)
            {
                result += random.Next(1, 100);
            }

            return result;
        }
     
        //kartno bitiş..............................
    }
}
