using System.Collections;
using System.Reflection;
namespace Listeler
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList liste = new LinkedList();

            liste.Add("Ahmet");
            liste.Add("Mehmet");
            liste.Add("Mahmut");
            liste.Add("Terminator");

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(liste.Count);

            Console.ReadLine( );
        }
    }

    public class Node
    {
        public string data;
        public Node next;

        public Node(string data)
        {
        this.data = data;
        next = null;
        }
    }
    public class LinkedList : IEnumerable
    {
        public Node headNode;
        public Node iter;

        public int Count = 0;

        public void Add(string data)
        {
            Node node= new Node(data);

            if (headNode == null)
            {
                headNode = node;
                headNode.next = null;
                iter = headNode;
            }

            else 
            { 
                iter.next = node;
                iter = iter.next;
            }
            Count++;
        }

        public IEnumerator GetEnumerator()
        {
            Node iter = headNode;

            if (iter == null)
            { 
                yield return null; 
            }
            else 
            { 
                while( iter!=null ) 
                {                    
                    yield return iter.data; 
                    iter = iter.next; 
                }
            }             
        }
    }
}