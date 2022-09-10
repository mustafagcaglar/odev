using System.Collections;
Console.Write("Cümle Giriniz: ");
string cumle = Console.ReadLine().ToLower();
char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
ArrayList sesliHarf = new();
foreach(char karakter in cumle)
{
    foreach(char sesli in sesliler)
    {
        if(karakter == sesli)
        {
            sesliHarf.Add(karakter);
        }
    } 
}
sesliHarf.Sort();
foreach (char eleman in sesliHarf)
{
    System.Console.Write(eleman + " ");
}

