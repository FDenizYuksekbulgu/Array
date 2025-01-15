
using System;
using System.Collections.Generic; 

class Program
{
    static void Main()
    {
        //1.SORU: 10 adet tam sayı alacak bir dizi tanımlandı.

        List<int> sayilar = new List<int>();

        //2.SORU: Bu dizinin elemanlarını bir for döngüsü ile doldurup,
        //foreach döngüsü ile tekrar ekrana yazdıralım.

        Console.WriteLine("Lütfen 10 adet tam sayı giriniz:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Sayı {i + 1}: ");
            int sayi = int.Parse(Console.ReadLine());
            sayilar.Add(sayi);
        }

        //Foreach döngüsü ile diziyi tekrar yazdıralım.
        Console.WriteLine("Girilen sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

        //3.SORU: Bu diziye kullanıcıdan alınan yeni bir değeri 11. eleman olarak ekleyelim.

        Console.WriteLine("Yeni bir sayı giriniz:");
        int yeniSayi = int.Parse(Console.ReadLine());
        sayilar.Add(yeniSayi);

        //Güncellenmiş listeyi yazdırma
        Console.WriteLine("\nGüncellenmiş sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }
        //4.SORU: Bu diziyi büyükten küçüğe doğru sıralayalım.

        sayilar.Sort();      //Önce küçükten büyüğe doğru sıralıyoruz.
        sayilar.Reverse();   //Sonra sıralamayı tersine çeviriyoruz.

        //Son hali;

        Console.WriteLine("Büyükten küçüğe sıralanmış sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }
    }
}
