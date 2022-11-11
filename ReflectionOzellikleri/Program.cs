using System.Reflection;
namespace ReflectionOzellikleri
{
    class Program
    {
        static void Main()
        {
            var asm = Assembly.GetExecutingAssembly();

            var type = typeof(MyNameSpace.User);

            var ins = (MyNameSpace.User)Activator.CreateInstance(type);

            //doğrudan ulamayız ama Reflection üzerinden ulaşabiliriz.Sadece ins.Ad  yazdığımızda hata verecektir.
            //Reflection üzerinden erişebiliriz.

            var prop = type.GetProperty("Ad", BindingFlags.NonPublic | BindingFlags.Instance);

            ins.setAd("Ali");
            Console.WriteLine(ins.getAd());
            //private bir değişkene/property'e eriştik ve değerini değiştirdik.
            prop.SetValue(ins, "Alexandronievski");
            Console.WriteLine(ins.getAd());
      

        }
    }
    class MyClass
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Yas { get; set; }
    }
}

namespace MyNameSpace
{
    class User
    {
        private string Ad { get; set; }

        public string getAd()
        {
            return Ad;
        }

        public void setAd(string ad)
        {
            Ad = ad;
        }
        public string Soyad { get; set; }
        public int Maas { get; set; }

        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}

/*

using System.Reflection;
namespace ReflectionOzellikleri
{
    class Program
    {
        static void Main()
        {
            var asm = Assembly.GetExecutingAssembly();

            var type = typeof(MyNameSpace.User);

            var ins = (MyNameSpace.User)Activator.CreateInstance(type);

            ins.Ad = "Mahmut";

            Console.WriteLine(ins.Ad);

            var prop = type.GetProperty("Ad");
            prop.SetValue(ins, "Alihandro");
            Console.WriteLine(ins.Ad);
        }
    }
    class MyClass
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Yas { get; set; }
    }
}

namespace MyNameSpace
{
    class User
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Maas { get; set; }

        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}

/*

using System.Reflection;
namespace ReflectionOzellikleri
{
    class Program
    {
        static void Main()
        {
            var asm = Assembly.GetExecutingAssembly(); 

            var type = typeof(MyNameSpace.User);
           
            var ins = (MyNameSpace.User)Activator.CreateInstance(type); //böyle de nesne oluşturabiliriz. bu type'a sahip MyNameSpace.User class'ından bir nesne oluştur.

            var method = type.GetMethod("Write");
            method.Invoke(ins, null);

            var method2 = type.GetMethod("Write2");
            object[] param = { "Ehlloe" };

            method2.Invoke(ins, param);
      
        }
    }
    class MyClass
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Yas { get; set; }
    }
}

namespace MyNameSpace
{
    class User
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Maas { get; set; }

        public void Write()
        {
            Console.WriteLine("Yazma metodu.");
        }

        public void Write2(string text)
        {
            Console.WriteLine(text);
        }
    }
}

/*
using System.Reflection;
namespace ReflectionOzellikleri
{
    class Program
    {
        static void Main()
        {
            var asm = Assembly.GetExecutingAssembly(); //şu anda çalışan Assembly'i al.

            //var type = asm.GetType("MyNameSpace.User"); yada typeof'ile tipini alabiliriz.

            var type = typeof(MyNameSpace.User);
           
            MyNameSpace.User ins = new MyNameSpace.User();

            var method = type.GetMethod("Write");
            method.Invoke(ins, null);

            var method2 = type.GetMethod("Write2");
            object[] param = { "Ehlloe" };

            method2.Invoke(ins, param);

            //foreach (var item in type.GetProperties())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //foreach (var item in type.GetMethods())
            //{
            //    Console.WriteLine(item.Name);
            //}
        }
    }
    class MyClass
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Yas { get; set; }
    }
}

namespace MyNameSpace
{
    class User
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Maas { get; set; }

        public void Write()
        {
            Console.WriteLine("Yazma metodu.");
        }

        public void Write2(string text)
        {
            Console.WriteLine(text);
        }
    }
}

*/