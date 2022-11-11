namespace RefOutParamsArguments
{
    class Program
    {      
        static void Main(string[] args)
        {
            int sum1, sum2, sum3, sum4;

            //farklı toplama işlemleri, parametre sayılarına dikakt edelim.
            Console.WriteLine(sum1 = SumParameters(1));
            Console.WriteLine(sum2 = SumParameters(1,2));
            Console.WriteLine(sum3 = SumParameters(3,3,3));
            Console.WriteLine(sum4 = SumParameters(4,4,4,4));

        }
        static int SumParameters(params int[] values)
        {
            //toplama işlemi
            int total = 0;
            foreach (var value in values)
            {
                total += value;
            }
            return total;
        }
    }
}

//namespace RefOutParamsArguments
//{
//    class Program
//    {
//        static int Max(int x, int y, out bool b) //max ile küçük büyük değeri return ediyoruz ama bool değeri de görmek istiyorsak;
//        {
//            if (x > y)
//            {
//                b = true;
//            }
//            else
//                b = false;

//            return Math.Max(x, y);
//        }
//        static void Main(string[] args)
//        {
//            bool a;
//            int max = Max(9 ,22, out a);
//            Console.WriteLine("Büyük sayı: " + max.ToString() + "\nBool değer: " + a);
//        }
//    }
//}


//namespace RefOutParamsArguments
//{
//    class Program
//    {
//        //ref keyword'ü değer tipinden önce kullanılmalıdır.

//        static void kareAl(ref double d) //bu değişken üzerinden global yapmadan da main'e değer gönderebiliriz.
//        {
//            d = d * d;
//        }
//        static void Main(string[] args)
//        {
//            double i = 3.45;
//            kareAl(ref i); //ref i -> ref double d , yani ref'in yanındaki değişkenin adresine atanır.
//            Console.WriteLine(i);
//        }
//    }
//}