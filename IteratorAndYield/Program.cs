//namespace IteratorAndYield
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {          
//            foreach (var item in Ciftsayi(5, 20))
//            {
//                Console.WriteLine(item);
//            }
//        }

//        public static IEnumerable<int> Ciftsayi(int altSinir, int ustSınır)
//        {
//            List<int> result = new List<int>();

//            for (int i = altSinir; i <= ustSınır; i++)
//            {
//                if (i % 2 == 0)
//                    result.Add(i);
//            }
//            return result;
//        }
//    }
//}
using System.Collections.Generic;

class Program {

    static IEnumerable<string> Days()
    {
        yield return "Monday";
        yield return "Tuesday";
        yield return "Wednesday";
        yield return "Thursday";
        yield return "Friday";
        yield return "Saturday";
        yield break;
        yield return "Sunday";
    }

    static void Main(string[] args)
    {
        foreach (var day in Days())
            Console.WriteLine(day);
    }
}

