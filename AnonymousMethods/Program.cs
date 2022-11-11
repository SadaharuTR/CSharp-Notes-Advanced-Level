namespace AnonymousMethods
{
    internal class Program
    {
        public delegate int Topla(int Sayi1, int Sayi2);
        static void Main(string[] args)
        {
            //Lambda
            Topla t1 = new Topla((a, b) => { return a + b; });

            //Lambda
            Topla t2 = (a, b) => { return a + b; };

            //Anonymous Method
            Topla t3 = delegate (int Sayi1, int Sayi2) //Önceden tanımlanmış bir metodun ismini delegemize belirtme gereksinimi duymadığımız için isimsiz metotdur.
            {
                return Sayi1 + Sayi2;
            };

            Console.WriteLine(t1(1, 3));
            Console.WriteLine(t2(2, 4));
            Console.WriteLine(t3(3, 5));
        }

    }
}