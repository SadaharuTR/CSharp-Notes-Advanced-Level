using System.Collections;

namespace IEnumInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();

            list.Add(15);
            list.Add("Merhaba");
            list.Add(12.5);

            foreach (var item in list) 
            {
                Console.WriteLine(item);
            }
            
        }
    }
}

class MyEnumerator : IEnumerator //ampule tıklayıp üyelerini implement edelim.
{
    //Burada IEnumerator ile iterasyonun nasıl olacağını belirtiriz. 

    ArrayList array;
    int index = -1;

    public MyEnumerator(ArrayList array)
    {
        this.array = array;
    }

    public object Current => array[index];

    public bool MoveNext()
    {
        index += 2; //index'imiz 2'şe artsın. -1 + 2 = 1. index o da yuakrıda Merhaba'ya denk gelir. Ondan sonra 2 arttırıp 3'e gelip çıkacaktır.
        //çünkü array'de o kadar eleman yok.
        return index < array.Count;
        //return ++index < array.Count; default olarak bu şekilde.
    }

    public void Reset()
    {
        index = -1;
    }
}
class MyList : IEnumerable
{
    ArrayList array;
    public MyList()
    {
        array = new ArrayList();
    }

    public object this[int index] 
    {
        get { return array[index]; }
        set { array[index] = value; }
    }
    public void Add(object value)
    {
        array.Add(value);
    }
    public void Clear(object value)
    {
        array.Clear();
    }
    public IEnumerator GetEnumerator() 
    {
        return new MyEnumerator(array); //kendi oluşturduğumuz metodumuzu çalıştıralım.
    }
}