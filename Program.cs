int result = 1;
for (int i = 1; i < 5; i++)
{
    result = result * 3;
}
Console.WriteLine(result);
Islemler instance = new();
Console.WriteLine(instance.Expo(3, 4));

string txt = "Lorem ipsum dolor sit amet.";
bool sonuc = txt.CheckSpaces();
Console.WriteLine(sonuc);
if (sonuc)
{
    Console.WriteLine(txt.RemoveWhiteSpaces());

}
Console.WriteLine(txt.buyukHarf());
Console.WriteLine(txt.kucukHarf());

int[] array = { 1, 4, 5, 7, 3, 78, 43, 12 };
array.SortArray();
array.EkranaYazdir();

int sayi = 9;
Console.WriteLine(sayi.ciftSayiMi());

Console.WriteLine(txt.ilkHarf());






public class Islemler
{
    public int Expo(int sayi, int üs)
    {
        if (üs < 2)
        {
            return sayi;
        }
        return Expo(sayi, üs - 1) * sayi;
    }
}

public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");

    }
    public static string RemoveWhiteSpaces(this string param)
    {
        string[] array = param.Split(" ");
        return string.Join("", array);

    }

    public static string buyukHarf(this string param)
    {
        return param.ToUpper();


    }

    public static string kucukHarf(this string param)
    {
        return param.ToLower();
    }

    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void EkranaYazdir ( this int [] param)
    {
        foreach (var n in param)
        {
            Console.WriteLine(n);
        }
    }

    public static bool ciftSayiMi(this int param)
    {
        return param % 2 == 0;

    }

    public static string ilkHarf(this string param)
    {
        return param.Substring(0,1);

    }
     

}
