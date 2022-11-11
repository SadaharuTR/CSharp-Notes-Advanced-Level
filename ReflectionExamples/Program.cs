using System.Reflection;
namespace ReflectionExamples
{
    class Program
    {
        static void Main()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //şu anda çalışan Assembly'i al.

            //Assembly içerisindeki türlerle ilgili bilgiyi almak için,

            Type type = asm.GetType("MyNameSpace.User");
            Console.WriteLine(type.Name);

            foreach (var item in type.GetProperties())
            {
                Console.WriteLine(item.Name);
            }
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
    }
}

/*

using System.Reflection;
namespace ReflectionExamples
{


    class Program
    {
        static void Main()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //şu anda çalışan Assembly'i al.

            //Assembly içerisindeki türlerle ilgili bilgiyi almak için,

            Type[] types = asm.GetTypes();

            foreach (var item in types)
            {
                Console.WriteLine(item.FullName);

                foreach (var item2 in item.GetProperties()) //item2, item üzerindeki tüm property'lerde dönecektir.
                {
                    Console.WriteLine($"{item2.Name}/{item2.PropertyType}");
                }
            }
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
    }
}

*/

/*
using System.Reflection;
namespace ReflectionExamples;

class Program
{
    static void Main()
    {
        Assembly asm = Assembly.GetExecutingAssembly(); //şu anda çalışan Assembly'i al.

        //Assembly içerisindeki türlerle ilgili bilgiyi almak için,

        Type[] types = asm.GetTypes();

        foreach (var item in types)
        {
            Console.WriteLine(item.Name);

            foreach (var item2 in item.GetProperties()) //item2, item üzerindeki tüm property'lerde dönecektir.
            {
                Console.WriteLine($"{ item2.Name}/{item2.PropertyType}");
            }
        }
    }
}

class MyClass
{
    public string Isim { get; set; }
    public string Soyisim { get; set; }
    public int Yas { get; set; }
}

Çıktı:
Program
MyClass
Isim/System.String
Soyisim/System.String
Yas/System.Int32
*/
/*
using System.Reflection;
namespace ReflectionExamples;

class Program
{
    static void Main()
    {
        Assembly asm = Assembly.GetExecutingAssembly(); //şu anda çalışan Assembly'i al.

        //Assembly içerisindeki türlerle ilgili bilgiyi almak için,

        Type[] types = asm.GetTypes();

        foreach (var item in types)
        {
            Console.WriteLine(item.Name);

            foreach (var item2 in item.GetProperties()) //item2, item üzerindeki tüm property'lerde dönecektir.
            {
                Console.WriteLine(item2.Name);
            }
        }
    }
}

class MyClass 
{
    public string Isim { get; set; }
    public string Soyisim { get; set; }
    public int Yas { get; set; }
}

Çıktı:
Program
MyClass
Isim
Soyisim
Yas
*/

/*
using System.Reflection;
namespace ReflectionExamples;

internal class Program
{
    static void Main(string[] args)
    {
        Assembly asm = Assembly.GetExecutingAssembly(); //şu anda çalışan Assembly'i al.

        //Assembly içerisindeki türlerle ilgili bilgiyi almak için,

        Type[] types = asm.GetTypes();

        foreach (var item in types)
        {
            Console.WriteLine(item.Name);
        }
    }
}

class MyClass //MyClass'ın üyelerine ulaşamadık.
{
    public string Isim { get; set; }
    public string Soyisim { get; set; }
    public int Yas { get; set; }
}

Çıktı:
Program
MyClass

*/

/*
using System.Reflection;
namespace ReflectionExamples;

internal class Program
{
    static void Main(string[] args)
    {
        Assembly asm = Assembly.GetExecutingAssembly(); //şu anda çalışan Assembly'i al.

        //Assembly içerisindeki türlerle ilgili bilgiyi almak için,

        Type[] types = asm.GetTypes();

        foreach (var item in types)
        {
            Console.WriteLine(item.Name);
        }
    }
}

class MyClass
{
    
}

class MyClass2
{

}

Çıktı:
Program
MyClass
MyClass2

*/

/*
using System.Reflection;
namespace ReflectionExamples;

internal class Program
{
    static void Main(string[] args)
    {
        Assembly asm = Assembly.GetExecutingAssembly(); //şu anda çalışan Assembly'i al.

        //Assembly içerisindeki türlerle ilgili bilgiyi almak için,

        Type[] types = asm.GetTypes();

        foreach (var item in types)
        {
            Console.WriteLine(item.Name);
        }
    }
}

Çıktı:
Program
*/

//---------------------------------------

/* 

using System.Reflection;
namespace ReflectionExamples;

    //Reflection, runtime esnasında bir assembly(.exe ve .dll dosyaları) içindeki tüm türler hakkında bilgi almamızı sağlayan bir tekniktir.
    //Bir namespace'dir.

    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //şu anda çalışan Assembly'i al.

            Console.WriteLine(asm);
        }
    }
// çalıştırırsak;
//ReflectionExamples, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
//çıktısını alırız. Şu anki bulunduğumuz Assembly ile ilgili bilgiler. 

*/