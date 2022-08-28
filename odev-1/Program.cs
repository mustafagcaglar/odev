    ///////////////////////////////////////////////////// Soru 1 /////////////////////////////////////////////////////////

Console.WriteLine("Lütfen bir sayı giriniz: ");
tekrargiris:
int n = int.Parse(Console.ReadLine());
while(n<=0)
    {
    Console.Write("Lütfen pozitif sayı giriniz! :");
    goto tekrargiris;
    }
   
int[] sayilar = new int[n];
           for(int i=0;i<n;i++)
            {
                Console.Write("{0}. sayıyı giriniz :", i+1);
                sayilar[i] = Int32.Parse(Console.ReadLine());
            }
            
            foreach (int cift in sayilar)
            {
                if(cift % 2 == 0)
                {
                    Console.WriteLine(cift);
                }
            }
           Console.ReadKey();

    ///////////////////////////////////////////////////// Soru 2 /////////////////////////////////////////////////////////

Console.WriteLine("1. Sayıyı giriniz: ");
tekrarin:
int m = int.Parse(Console.ReadLine());
while(m<=0)
    {
    Console.Write("Lütfen pozitif sayı giriniz! :");
    goto tekrarin;
    }
Console.WriteLine("2. Sayıyı giriniz: ");
tekrarin2:
int y = int.Parse(Console.ReadLine());
while(y<=0)
    {
    Console.Write("Lütfen pozitif sayı giriniz! :");
    goto tekrarin2;
    }

int[] eleman = new int[m];
for(int i=0;i<m;i++)
            {
                Console.Write("{0}. sayıyı giriniz :", i+1);
                eleman[i] = Int32.Parse(Console.ReadLine());
            }
foreach (int tam in eleman)
           {
                if((tam % y == 0) || (tam == y))
                {
                    Console.WriteLine(tam);
                }
            }
            Console.ReadKey();     

    ///////////////////////////////////////////////////// Soru 3 /////////////////////////////////////////////////////////

Console.WriteLine("Lütfen bir sayı giriniz: ");
tekrarout:
int k = int.Parse(Console.ReadLine());
while(k<=0)
    {
    Console.Write("Lütfen pozitif sayı giriniz! :");
    goto tekrarout;
    }

string[] stringArray = new string[k];
for(int i=0;i<k;i++)
            {
                Console.Write("{0}. kelimeyi giriniz :", i+1);
                stringArray[i] = (Console.ReadLine());
            }

Array.Reverse(stringArray);

foreach(var kelime in stringArray)
   Console.WriteLine(kelime);

    ///////////////////////////////////////////////////// Soru 4 /////////////////////////////////////////////////////////

            Console.Write("Cümleyi Giriniz  : ");
            string cumle = Console.ReadLine();
            int harfSayac=0,kelimeSayac=1;
            for (int i = 0; i < cumle.Length; i++)
            {
                harfSayac++;
                if (cumle[i]==' ')
                {
                    kelimeSayac++;
                    harfSayac--;
                }
            }    
            Console.WriteLine("Cümle toplam {0} harf içerir.", harfSayac);
            Console.WriteLine("Cümle toplam {0} kelime içerir.", kelimeSayac);
            Console.ReadLine();
           
        