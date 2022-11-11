using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Product //iki farklı cs içerisinde aynı class'ı iki kere oluşturduk.
    {
        //eğer partial yazmasaydık aynı isimde class mevcut hatası alacaktık.

        public string Name { get; set; }
    }
}
