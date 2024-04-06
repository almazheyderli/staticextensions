using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    internal class Product
    {
        public string Name;
        public int Count;
        public string Type;
        private static int _no;
        public int No;
        private static double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("0 dan kicik ola bilmez");
                }
                else
                {
                    _price = value;
                }
            }
        }



        public Product(string name,string type,double price)
        {
            _no++;
            No = _no;
            Name = name;
            Type = type;
         
            Price = price;



        }

        
        public override string ToString()
        {
            return $"{Name} {Type} {Count}  {Price}  {No}";
        }
    }
}
