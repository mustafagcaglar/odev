﻿using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList asalSayi = new();
        ArrayList asalSayiOlmayan = new();

        for(int k = 0; k < 20; k++)
        {
            hataligiris:
            Console.Write("{0}. Lütfen pozitif bir sayı giriniz: ", k+1);
            string girilenSayi = Console.ReadLine();
            if(int.TryParse(girilenSayi,out int sayi) && sayi>0 && sayi!=null)
            {
                int sayac=0;
                for(int j=1;j<=sayi;j++)
                {
                    if(sayi%j==0)
                    {
                        sayac++;
                    }
                }
                if(sayac==2)
                {
                    asalSayi.Add(sayi);
                }
                else
                {
                    asalSayiOlmayan.Add(sayi);
                }
            }
            else
            {
                Console.WriteLine("Hatalı giriş!");
                goto hataligiris;
            }
        }

        asalSayi.Reverse();
        asalSayiOlmayan.Reverse();
        Console.WriteLine("** ASAL SAYILAR **");
        decimal asalToplam=0;
        decimal asalOlmayayanToplam=0;
        foreach (int asalOlanlar in asalSayi)
        {
            Console.Write(asalOlanlar+" ");
            asalToplam+=asalOlanlar;
        }
        Console.WriteLine();
        Console.WriteLine("Toplam Eleman Sayısı: "+asalSayi.Count);
        Console.WriteLine("Ortalama: "+asalToplam/asalSayi.Count);
        Console.WriteLine("** ASAL OLMAYAN SAYILAR **");
         foreach (int asalOlmayanlar in asalSayiOlmayan)
        {
            Console.Write(asalOlmayanlar+" ");
            asalOlmayayanToplam+=asalOlmayanlar;
        }
        Console.WriteLine();
        Console.WriteLine("Toplam Eleman Sayısı: "+asalSayiOlmayan.Count);
        Console.WriteLine("Ortalama: "+asalOlmayayanToplam/asalSayiOlmayan.Count);

    }
}
