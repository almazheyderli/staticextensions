using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    internal class Store
    {
        public Product[] Products = new Product[] { };

        private static int _id;
        public static int Id;


        public Store()
        {
            _id++;
            Id = _id;

        }

        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }
        public Product[] RemoveProductByNo(int no)
        {
            Product[] newProduct = new Product[] { };
            foreach (Product p in Products)
            {
                if (p.No != no)
                {
                    Array.Resize(ref newProduct, newProduct.Length + 1);
                    newProduct[newProduct.Length - 1] = p;
                }
            }
            return newProduct;
        }
        public Product GetProduct(int no)
        {
            foreach (Product p in Products)
            {
                if (p.No != no)
                {
                    Console.WriteLine("mehsul tapilmadi");
                }
                else
                {
                    return p;
                }
            }
            return null;
        }

        public Product[] FilterProductsByType(string type)
        {
            Product[] typePr= new Product[] { };

            foreach (Product p in Products)
            {
                if (p.Type != type)
                {
                    Console.WriteLine("mehsul tapilmadi");
                }
                else
                {
                   Array.Resize(ref typePr,typePr.Length + 1);
                    typePr[typePr.Length - 1]= p;
                }
            }
            return typePr;
        }
        
        public Product[] FilterProductsByName(string name) 
        {
            Product[] namePr= new Product[] { };
            foreach(Product p in Products)
            {
                if(p.Name != name)
                {
                    Console.WriteLine("mehsul tapilmadi");

                }
                else
                {
                    Array.Resize(ref namePr,namePr.Length + 1);
                    namePr[namePr.Length - 1]= p;
                }
             
            }
            return namePr;
        }

        public void Sale(int no, Person person)
        {
            Product product = GetProduct(no);
            if(product != null && person.Cash >= product.Price)
            {
                product.Count--;
              product.Price -= person.Cash;
                Console.WriteLine("odenis ugurla yerine yetirildi");
            }
            else
            {
                Console.WriteLine("ugursuz odenis");
            }

        }
    }
}