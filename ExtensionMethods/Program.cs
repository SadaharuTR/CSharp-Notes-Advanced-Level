namespace ExtensionMethods;
class Program
{
    static void Main()
    {
        string x = "Selam".Ekle("XYZ");
        Console.WriteLine(x);
    }
}
static class Extensions
{
    public static string Ekle(this object obj, string yazi) //ikinci yazılan string yazi'yı normal parametre olarak alacaktır.
    {
        return obj + yazi;
    }
}

//namespace ExtensionMethods;

//class Program
//{
//    static void Main()
//    {
//        string x = "45";
//        int y = 9;

//        Console.WriteLine(x.TamSayiyaCevir()+y);
//    }
//}
//static class Extensions
//{
//    public static int TamSayiyaCevir(this object obj)
//    {
//        return Convert.ToInt32(obj);
//    }
//}

//namespace ExtensionMethods;

//class Program
//{
//    static void Main()
//    {
//        char[] dizi = "Merhaba".KarakterlereCevir();

//        foreach (var item in dizi)
//        { 
//            Console.WriteLine(item); 
//        }
//    }
//}

////Extension Metotların static class'larda olması şarttır.
//static class Extensions
//{
//    //static class'ların özelliğinden gereği tüm üyeleri de static olmak zorundadır.

//    public static char[] KarakterlereCevir(this string text) 
//    {
//        char[] chars = new char[text.Length];

//        for (int i = 0; i < chars.Length; i++)
//        {
//            chars[i] = text[i];
//        }
//        return chars;
//    }
//}