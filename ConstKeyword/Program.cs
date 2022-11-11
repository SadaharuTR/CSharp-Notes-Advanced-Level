namespace ConstKeyword
{
     class Program
    {
        const double PI = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine(PI);

            PI = 2.72; //hata verir. Const ile sabit bir değer olarak yukarıda belirledik. 
        }
    }
}