namespace AttibutesNitelikler;

class Program //Metotlar ile Attribute
{
    static void Main(string[] args)
    {
        //AlisVeris sınıfından aşağıdaki gibi nesne ürettiğimizde ise,
        AlisVeris alisVeris = new AlisVeris(true);
        AlisVeris alisVeris2 = new AlisVeris(false);
        Console.Read();
    }
}

[AttributeUsage(AttributeTargets.Method)]
class KontrolAttribute : Attribute
{
    public void Durum(bool Durum)
    {
        if (Durum)
            Console.WriteLine("Kontrol tamamlandı.");
        else
            Console.WriteLine("Kontrol ediliyor.");
    }
}
//İlgili özniteliği kullanacak metodu barındıran sınıfımızı inşa edelim.
class AlisVeris
{
    //ilgili sınıfın tipinde bulunan metodlara bağlı attributelar tetiklenmekte ve basit bir algoritmik işlem gerçekleştirilmektedir.
    public AlisVeris(bool Durum)
    {
        foreach (var method in typeof(AlisVeris).GetMethods())
        {
            foreach (var attr in method.GetCustomAttributes(false))
            {
                if (method.Name == "AlisVerisYap")
                {
                    KontrolAttribute kontrolAttribute = (KontrolAttribute)attr;
                    kontrolAttribute.Durum(Durum);
                    AlisVerisYap(Durum);
                }
            }
        }
    }

    [Kontrol]
    public void AlisVerisYap(bool Durum)
    {
        if (Durum)
            Console.WriteLine("Alış veriş yapıldı.");
        else
            Console.WriteLine("Alış veriş yapılamadı");
    }
}




//namespace AttibutesNitelikler
//{
//    class Program //Property'e özel Attribute
//    {
//        static void Main(string[] args)
//        {
//            AlisVeris alisVeris = new AlisVeris(150);
//            AlisVeris alisVeris2 = new AlisVeris(10);
//            Console.Read();
//        }
//    }
//    //“KontrolAttribute” sınıfını öznitelik olarak kullanabilmek için “Attribute” sınıfından türettik ve “AttributeUsage” özniteliği sayesinde
//    //bu özniteliğin sadece Property'lerde çalışacağını belirttik.
//    [AttributeUsage(AttributeTargets.Property)]
//    class KontrolAttribute : Attribute
//    {
//        public int Para { get; set; }
//    }

//    //Özniteliği kullanacağımız propertynin bulunduğu sınıfı inşa edelim.
//    class AlisVeris
//    {
//        public AlisVeris(int Fiyat) //propertyi kullanacağımız sınıfın constructerında bu sınıfa bağlı propertylere tanımlanmış tüm attributeları tetiklemekteyiz.
//        {
//            this.Fiyat = Fiyat;
//            foreach (var property in typeof(AlisVeris).GetProperties())
//            {
//                foreach (var attr in property.GetCustomAttributes(false))
//                {
//                    if (property.Name == "Fiyat")
//                    {
//                        KontrolAttribute kontrolAttribute = (KontrolAttribute)attr;
//                        if ((int)property.GetValue(this) > kontrolAttribute.Para)
//                            Console.WriteLine("Alışveriş yapıldı.");
//                        else
//                            Console.WriteLine("Para eksik");
//                    }
//                }
//            }
//        }

//        //Fiyat propertysinin Kontrol Attribute’una verilen değer ile kıyaslaması yapılmaktadır.
//        [Kontrol(Para = 100)]
//        public int Fiyat { get; set; }
//    }
//}