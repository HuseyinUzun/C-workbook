using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examplequestions1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region iki sayının toplamını veren uygulamayı yazınız.


            //    int sayi1 = 10;
            //    int sayi2 = 345;
            //    int sayi1 = 10, sayi2 = 20;
            //    //int sonuc =  sayi1 + sayi2;
            //    Console.WriteLine(sayi1 + sayi2);
            //    Console.ReadLine();
            #endregion

            #region Sayı Konsol
            //Console.WriteLine("Lütfen sayi1 değerini giriniz.");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen sayi2 değerini giriniz.");
            //int sayi2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(sayi1 + sayi2);
            #endregion


            #region 3.örnek  try-catch hata durumunda çözüm
            //try
            //{
            //    Console.WriteLine("Lütfen sayi1 değerini giriniz.");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Lütfen sayi2 değerini giriniz.");
            //    int sayi2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine(sayi1 + sayi2);
            //}
            //catch
            //{
            //    Console.WriteLine("Lütfen doğru bir sayı değerini giriniz.");
            //}
            #endregion



            #region 4.örnek try-cath uygulaması
            //try
            //{
            //    Console.WriteLine("Lütfen birinci sayıyı giriniz.");
            //    int sayi1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
            //    int sayi2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Toplam : " + (sayi1 + sayi2));
            //}
            //catch 
            //{
            //    Console.WriteLine("Lütfen doğru bir ifade girip tekrar deneyiniz.");


            //}



            #endregion

            #region 5.örnek Kullanıcının girdiği iki sayının kareleri toplamı

            //{
            //        //çözüm 1.
            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int sayi1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int sayi2 = int.Parse(Console.ReadLine());

            //    int sonuc = sayi1 * sayi1 + sayi2 * sayi2;

            //    Console.WriteLine(sonuc);
            //}

            //çözüm 2.

            //{
            //    Console.WriteLine("Lütfen birinci sayıyı giriniz.");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //   double sonuc = Math.Pow(sayi1, 2) + Math.Pow(sayi2, 2);
            //    Console.WriteLine(sonuc);

            //}

            //çözüm 3.
            //{
            //    Console.WriteLine("Lütfen birinci ve ikinci sayıları giriniz.");
            // double sonuc = Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2);
            //    Console.WriteLine("Kareleri toplamı : " + sonuc);


            //}

            #endregion


            #region 6.örnek 1'den 10'a kadar olan sayılaarın küpleri toplamı
            #endregion

            #region 7.örnek for döngüsü

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("for döngüsü 10a kadar çalıştı");
            //}

            #endregion

            #region 8.örnek while Dögüsü - for ile kıyaslama

            //for (int i = 0; i < 10; i++) 
            //{
            //    Console.WriteLine("for döngüsü çalıştı");

            //}
            //Console.WriteLine("---------------------------");

            //int _i = 0;
            //while (_i < 10) 
            //{
            //    Console.WriteLine("while döngüsü çalıştı");
            //    _i++;
            //}

            #endregion

            #region 9.örnek Klavyeden girilen sayıdan geriye doğru 0'a kadar sayan bir sayaç

            //int sayi = int.Parse(Console.ReadLine());

            //while (sayi > 0)
            //{
            //    Console.WriteLine(sayi - 1 ); /*-1 ve eşit değil çünkü girilen sayıdan sonra düşmeye başlasın diye*/
            //    sayi--;
            //}


            #endregion

            #region 10.örnek 0 ile 100 arasındaki tek sayıları toplayarak ekrana gösteren program

            //int i = 0, toplam = 0;

            //while (i <= 100)
            //{
            //    if(i % 2 == 1)
            //        toplam += i;
            //    i++;

            //}
            //Console.WriteLine(toplam);

            #endregion

            #region 11.örnek Oankitarihinsaniyedeğeri10'unkatıysasaati/tarihiekrandagösteren program

            //while (true) 
            //{
            //    if(DateTime.Now.Second % 10 == 0)
            //            Console.WriteLine(DateTime.Now);
            //}

            #endregion

            #region 12.örnek if ile not geçme durumunu konsola yazdırma programı

            //var not = 70;


            //if (not>50)
            //{
            //    Console.WriteLine("Geçtiniz.");

            //}
            //    if(not<=50) 
            //{
            //    Console.WriteLine("kaldınız.");
            //}

            #endregion

            #region 13.örnek Kullanıcı t harfi girene kadar sınırsız sayıyı toplayan ve ekrana yazdıran program

            //int toplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    string girilenDeger = Console.ReadLine();
            //    if(girilenDeger == "t")
            //    {
            //        Console.WriteLine("Toplam Sonuç : " + toplam);
            //        break;
            //    }
            //    else
            //    {
            //        toplam += int.Parse(girilenDeger);
            //    }
            //}


            #endregion


            #region 14.örnek[hatalı] Kullanıcının girdiği sonsuz adet sayıdan pozitif olanları çarpan ve t enter yapıldığında sonucu ekrana yazdıran program

            //int carpim = 1;
            //while(true)
            //{
            //    Console.WriteLine("Lütfen bir sayı giriniz.");
            //    string girilenDeger = Console.ReadLine();
            //    if (girilenDeger == "t")
            //    { 
            //        Console.WriteLine(carpim);
            //        break;
            //    }

            //    else
            //    {
            //    int sayi = int.Parse(girilenDeger);
            //    }

            //}

            #endregion

            #region 15.örnek 1 ile 1000 arasında 7'nin katı olmayan sayıları ekrana yazdıran program

            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        continue;


            //    }
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 16.örnek  Kullanıcı 'c' tuşuna basana kadar sonsuz döngüde dönen program

            //while (true)
            //{
            //    if (Console.ReadKey().KeyChar == 'c')
            //    {
            //        Console.WriteLine("Uygulama sona ermiştir.");
            //        return;
            //    }
            //    Console.WriteLine("Uygulama çalışıyor...");
            //}

            #endregion

            #region 17.örnek Kullanıcının girdiği 3 tane not ortalamasına göre sonuç veren program

            //80-100 A,60-80 B+,40'tan küçükse F yazdıran kod parçacıkları

            //Console.WriteLine("Lütfen birinci sayıyı giriniz.");
            //int birincisayi = int.Parse(Console.ReadLine());
            //Console.WriteLine("lütfen ikinci....");
            //int ikincisayi = int.Parse(Console.ReadLine());
            //Console.WriteLine("üçüncü... ");
            //int ücüncüsayi = int.Parse(Console.ReadLine());

            //int sonuc = (birincisayi + ikincisayi + ücüncüsayi) / 3;

            //if (sonuc > 80 && sonuc <= 100)
            //{
            //    Console.WriteLine("Not değeriniz : A ");
            //}
            //else if (sonuc > 60 && sonuc < 80)
            //{
            //    Console.WriteLine("Not değeriniz : B+");
            //}
            //else if (sonuc > 40 && sonuc < 60)
            //{
            //    Console.WriteLine("Not değeriniz : B");
            //}
            //else
            //{
            //    Console.WriteLine("Not değeriniz : F'dir.");
            //}




            #endregion

            #region 18.örnek ATM Programı

            //Kullanıcıdan aşağıdaki tuşlamalardan birisi yapması istenecek
            //1-bakiye görüntüleme
            //2-Para Çekme
            //3-Para Yatırma
            //4-Q çıkış

            int bakiye = 1000;

            Console.WriteLine("HO BANK'a hoşgeldiniz.");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("1-Bakiye Görüntüleme");
            Console.WriteLine("2-Para Çekme");
            Console.WriteLine("3-Para Yatırma");
            Console.WriteLine("4-Q çıkış");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Şuanki Bakiyeniz : " + bakiye + "TL");
                Console.ReadLine();

            }
            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                if (cekilecek_tutar <= bakiye)
                {

                    Console.WriteLine("Kalan Tutar : " + (bakiye - cekilecek_tutar) + "TL");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla para çekemezsiniz.");
                }
            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak istediniz tutarı giriniz");
                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yeni Bakiyeniz : " + (bakiye + yatirilacak_tutar) + "TL");
                Console.ReadLine();

            }
            else if (secim == "q")
            {
                Console.WriteLine("ATM'den çıkış yapılıyor...");
                Console.WriteLine("Çıkış yapıldı,iyi günler dileriz.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                Console.ReadLine();
            }


            #endregion

            #region 19.örnek
            #endregion

            #region 20.örnek
            #endregion
            #region 21.örnek
            #endregion

            #region 22.örnek
            #endregion

            #region 23.örnek
            #endregion

        }

    }
}
