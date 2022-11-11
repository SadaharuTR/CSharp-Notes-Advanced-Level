using System;

namespace SealedKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //
        }
    }

    class A
    {
        public virtual void deneme()
        {
            Console.WriteLine("A-Deneme");
        }
    }

    class B : A
    {
        public sealed override void deneme()
        {
            Console.WriteLine("B-Deneme");
        }
    }
    class C : B
    {
        public override void deneme() //yukarıda Sealed ile işaretlendiği için override işlemi yapılamaz hatası alınır.
        {
            Console.WriteLine("C-Deneme");
        }
    }
}