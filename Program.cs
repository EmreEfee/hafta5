using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array(dizi)

            //Program yazarken bazen aynı türden birden fazla değer tutmak zorunda kalabiliriz.
            //Bu gibi durumlarda array(dizi) mantığı devreye girer.
            //Array tanımlama işlemini [] işareti ile belirtiriz.
            //Array tanımlaması yaparken içerisinde aynı türden kaç adet değer tutacak ise 
            //o sayıyı tanımlama esnasında belirtiriz.
            //Array içerisindeki elemanlara index numarası ile erişim sağlarız.
            // Index numarası sayesinde array içerisindeki elemanlara değer ataması yapabilir
            //güncelleme yapabilir veya okuma işlemi yapabiliriz.
            //***Arraylerin içerisinde yer alan ilk elemanın index numarası '0' dır.
            //***Son elemanın index numarası ise eleman sayısının bir eksiğidir.


            //Syntax

            // veriTipi[] takmaAd = new veriTipi[Eleman sayısı];

            // Ornek

            // İçerisinde 5 adet eleman barındıran , int türünden bir array oluşturalım.
            /*
            int[] sayilar = new int[3];
            int toplam;
            double ort;
            
            sayilar[0] = 5;
            sayilar[1] = -200;
            sayilar[2] = 155;
            sayilar[3] = 5520;
            sayilar[4] = -25;

            Console.WriteLine("0. index numarasındaki 1. eleman : "+sayilar[0]);
            Console.WriteLine("1. index numarasındaki 2. eleman : " + sayilar[1]);
            Console.WriteLine("2. index numarasındaki 3. eleman : " + sayilar[2]);
            Console.WriteLine("3. index numarasındaki 4. eleman : " + sayilar[3]);
            Console.WriteLine("4. index numarasındaki 5. eleman : " + sayilar[4]);
            

            //kullanıcıdan 3 adet sayı talep ededlim
            //Sayıların toplamını ve ortalamasını ekrana yazalım
            //Değişken tanımlamasını array ile yapalım.

            Console.Write("İlk sayıyı giriniz: ");
            sayilar[0] = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            sayilar[1] = int.Parse(Console.ReadLine());
            Console.Write("Üçüncü sayıyı giriniz: ");
            sayilar[2] = int.Parse(Console.ReadLine());
            toplam = sayilar[0] + sayilar[1] + sayilar[2];
            Console.WriteLine("Sayıların toplamı : "+toplam);
            ort = toplam / 3;
            Console.WriteLine("Sayıların ortalaması : "+ort);
            */
            /* bunu hoca yazdı
            int[] toplanacakSayilar = new int[3];

            Console.Write("1. Sayıyı giriniz: ");
            toplanacakSayilar[0] = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz: ");
            toplanacakSayilar[1] = int.Parse(Console.ReadLine());
            Console.Write("3. Sayıyı giriniz: ");
            toplanacakSayilar[2] = int.Parse(Console.ReadLine());

            int toplam = toplanacakSayilar[0] + toplanacakSayilar[1] + toplanacakSayilar[2];
            //Array içerisindeki eleman sayısını .Length komutu ile öğrenebiliriz.
            double ortalama = (double)toplam / toplanacakSayilar.Length;
            Console.WriteLine("Sayıların toplamı: "+toplam);
            Console.WriteLine("Sayıların Ortalaması: "+ortalama);
            Console.WriteLine("Dizinin Eleman sayısı: "+toplanacakSayilar.Length);
            */


            //Ornek 

            //Kullanıcıdan 5 adet sayı talep edelim

            // talep edilen sayıların 3 e tam bölünenlerini ekrana yazdıralım.
            /*
            int[] Sayilarr = new int[5];


            Console.Write("1. Sayıyı giriniz: ");
            Sayilarr[0] = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz: ");
            Sayilarr[1] = int.Parse(Console.ReadLine());
            Console.Write("3. Sayıyı giriniz: ");
            Sayilarr[2] = int.Parse(Console.ReadLine());
            Console.Write("4. Sayıyı giriniz: ");
            Sayilarr[3] = int.Parse(Console.ReadLine());
            Console.Write("5. Sayıyı giriniz: ");
            Sayilarr[4] = int.Parse(Console.ReadLine());

            if (Sayilarr[0] % 3 == 0)
            {
                Console.WriteLine("3 e bölünen ilk sayı : "+Sayilarr[0]);
            }
            if (Sayilarr[1] % 3 == 0)
            {
                Console.WriteLine("3 e bölünen ilk sayı : " + Sayilarr[1]);
            }
            if (Sayilarr[2] % 3 == 0)
            {
                Console.WriteLine("3 e bölünen ilk sayı : " + Sayilarr[2]);
            }
            if (Sayilarr[3] % 3 == 0)
            {
                Console.WriteLine("3 e bölünen ilk sayı : " + Sayilarr[3]);
            }
            if (Sayilarr[4] % 3 == 0)
            {
                Console.WriteLine("3 e bölünen ilk sayı : " + Sayilarr[4]);
            }
            */
            //2.yöntem
            /*
            int[] sayilarr = new int[5];
            for (int i = 0; i < sayilarr.Length; i++)
            {
                Console.Write((i+1)+". Sayıyı Giriniz: ");
                sayilarr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < sayilarr.Length; i++)
            {
                if (sayilarr[i] % 3==0)
                {
                    Console.WriteLine((i+1)+". Sayı 3'e tam bölünüyor: "+sayilarr[i]);
                }
            }
            */

            // Eleman sayısının kullanıcının belirlediği bir dizi oluşturalım
            //Sonra bu dizinin içini isimlerle dolduralım.


            /*
            int adet;

            Console.Write("Kaç Kişi Girmek İstersiniz: ");
            adet = int.Parse(Console.ReadLine());

            string[] kisiler = new string[adet];


            for (int i = 0; i < kisiler.Length; i++)
            {
                Console.WriteLine((i+1)+". Kişinin adını giriniz: ");
                kisiler[i] = Console.ReadLine();

            }

            Console.WriteLine();

            foreach (var item in kisiler)
            {
                Console.WriteLine(item);
            }

            */

            // Kullanıcıdan kaç adet isim soyisim girmek istediğini alalım
            //kullanıcının girmiş olduğu sayı kadar ayrı ayrı şekilde isim ve soy isim talep edelim
            //Bu işlemler bittikten sonra isim soyisim şeklinde yan yana yazdıralım.
            /*
            int isimsayisi;
            

            Console.Write("Kaç isim ve soyisim yazmak istersiniz: ");
            isimsayisi = int.Parse(Console.ReadLine());

            string[] isimvesoyisim = new string[isimsayisi];

            for (int i = 0; i < isimvesoyisim.Length; i++)
            {
                Console.WriteLine((i + 1) + ". Kişinin ismini ve soyismini giriniz");
                isimvesoyisim[i] = Console.ReadLine();
            }
            Console.WriteLine();
            foreach (var item in isimvesoyisim)
            {
                Console.WriteLine(item);
            }
            */
            /*
            int sayi;

            Console.WriteLine("Kaç kişi gireceksiniz: ");
            sayi = int.Parse(Console.ReadLine());

            string[] isimler = new string[sayi];
            string[] soyisimler = new string[sayi];

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Clear();
                Console.Write("İsim Giriniz: ");
                isimler[i] = Console.ReadLine();
                Console.Write("Soyisim Giriniz: ");
                soyisimler[i] = Console.ReadLine();
            }
            Console.Clear();

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]+ " "+soyisimler[i]);
            }
            */

            // kullanıcıya kaç adet öğrenci gireceğini soralım
            //Bu öğrencilerin ismini,öğrenci numarasını,  telefon bilgilerini kayıt edelim
            //Kayıt işlemi bittikten sonra kullanıcıya öğrenci numarası ile listede o numarada
            //mevcut kişinin olup olmadığını gösterelim.

            int adet;
            Console.WriteLine("Kaç adet öğrenci girişi yapılacak: ");
            adet = int.Parse(Console.ReadLine());


            string[] ogenciNo = new string[adet];
            string[] isim = new string[adet];
            string[] telefonNo = new string[adet];

            for (int i = 0; i < isim.Length; i++)
            {
                Console.Clear();
                Console.Write("Öğrencinin numarasını giriniz: ");
                ogenciNo[i] = Console.ReadLine();
                Console.Write("Öğrencinin ismini girin: ");
                isim[i] = Console.ReadLine();
                Console.Write("Öğrencinin telefon numarasını giriniz: ");
                telefonNo[i] = Console.ReadLine();

            }
            int indexNo;

            do
            {
               

                Console.Write("Aramak istediğiniz Öğrencinin okul numarasını giriniz: ");
                string arananNo = Console.ReadLine();
                indexNo = Array.IndexOf(ogenciNo, arananNo);// Bulduğu ilk değerin index numarasını döndürür.()içerisine metinsel veri tipi alır.
                if (indexNo== -1)
                {

                    Console.WriteLine("Bu numarada kayıtlı öğrenci bulunamadı.");




                }
                else
                {

                    Console.Clear();
                    Console.WriteLine("Aranan kişin öğrenci numarası: "+ogenciNo[indexNo]+" isimi: "+isim[indexNo]+" telefon numarası: "+telefonNo[indexNo]);




                }






            } while (indexNo== -1);

            





            Console.ReadKey();
        }
    }
}
