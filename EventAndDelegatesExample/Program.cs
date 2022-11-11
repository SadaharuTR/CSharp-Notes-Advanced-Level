using System.Net.WebSockets;
//EventArgs event ile ilgili değerleri,dataları,verileri saklayan-içeren bir class'tır.
//sender ise gönderici anlamında. Misal olarak butona tıkladığınızda o olayda gönderici olan butondur.
namespace EventAndDelegatesExample;
class Program
{
    static event EventHandler myEvent;
    static void Main(string[] args)
    {
        myEvent += Program_myEvent;

        Button btn = new Button() { Text = "Click" , Width = 15, Height = 40 };

        ButtonInfo info = new ButtonInfo() { Date = "2020" };

        myEvent(btn, info);
    }

    private static void Program_myEvent(object? sender, EventArgs e)
    {
        Console.WriteLine(((Button)sender).Text + " " + ((Button)sender).Width + " " + ((Button)sender).Height);
        Console.WriteLine(((ButtonInfo)e).Date);
    }

    class Button
    {
        public string Text;
        public double Width;
        public double Height;
    }

    class ButtonInfo : EventArgs
    {
        public string Date;
    }
}


//--------------------------------------------

//using System.Net.WebSockets;

//namespace EventAndDelegatesExample;
////eventler belli bir şart sağlandığında kendiliğinden gerçekleşen olaylar zinciri (metotlar)
////form arayüzlerinde daha çok tercih edilirler. buton_click olayı gibi.
////delegate'ler ile birlikte kullanılırlar.

//delegate void Test();
//class Program
//{
//    static event Test x;
//    static void Main(string[] args)
//    {
//        x += new Test(Deneme);
//        x();
//    }

//    static void Deneme()
//    {
//        Console.WriteLine("Hello"); 
//    }
//}

//----------------------------------

//delegate void Test();
//class Program
//{
//    static event Test x
//    {
//        add//evente metot eklendiğinde çalışır.
//        {
//            Console.WriteLine("Metot eklendi.");
//        }
//        remove//evente metot çıkarıldığında çalışır.
//        {
//            Console.WriteLine("Metot çıkarıldı.");

//        }
//    }
//    static void Main(string[] args)
//    {
//        x += Deneme;
//        x += Deneme;
//        x -= Deneme;

//    }

//    static void Deneme()
//    {
//        Console.WriteLine("Hello");
//    }
//}
//-----------------------------------

//using System.Net.WebSockets;

//namespace EventAndDelegatesExample;
////eventler belli bir şart sağlandığında kendiliğinden gerçekleşen olaylar zinciri (metotlar)
////form arayüzlerinde daha çok tercih edilirler. buton_click olayı gibi.
////delegate'ler ile birlikte kullanılırlar.

//delegate void Test();
//class Program
//{
//    static event Test x;
//    static void Main(string[] args)
//    {
//        x += Deneme;
//        x += Deneme;
//        x -= Deneme;
//        x();
//    }

//    static void Deneme()
//    {
//        Console.WriteLine("Hello");
//    }
//}

//-----------------------------------


//namespace EventAndDelegatesExample;
////eventler belli bir şart sağlandığında kendiliğinden gerçekleşen olaylar zinciri (metotlar)
////form arayüzlerinde daha çok tercih edilirler. buton_click olayı gibi.
////delegate'ler ile birlikte kullanılırlar.

//delegate void Test();
//class Program
//{
//    static event Test x;
//    static void Main(string[] args)
//    {
//        x += Deneme;
//        x += Program_x;
//        x();
//    }

//    private static void Program_x()
//    {
//        Console.WriteLine("Hola");
//    }

//    static void Deneme()
//    {
//        Console.WriteLine("Hello");
//    }
//}