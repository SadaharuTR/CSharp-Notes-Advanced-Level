using System.Reflection;

namespace ReflectionAndAssemblySezond
{
    class Program
    {
        static void Main(string[] args)
        {
            var asm = Assembly.LoadFrom(@"C:\Users\acdem\OneDrive\Masaüstü\İleri Seviye C#\ReflectionAndAssembly\bin\Debug\net6.0\ReflectionAndAssembly.exe");
            Type[] types = asm.GetTypes();
            foreach (var item in types) 
            {
                Console.WriteLine(item.FullName);
            }
        }
    }
}