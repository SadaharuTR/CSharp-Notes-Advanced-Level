namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            //oluşturmuş olduğumuz p nesnesi ile p. yazdığımızda Id ve Name'in ikisinin de geldiğini görürüz.

            p.Name = "...";
            p.Id = 1;
        }
    }
}