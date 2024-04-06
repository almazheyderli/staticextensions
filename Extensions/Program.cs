using System.Linq.Expressions;
using System.Runtime.Serialization.Json;

namespace Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Store store= new Store();
            string num;
            bool check= true;
            do
            {
                Console.WriteLine("1.Mehsul elave et");
                Console.WriteLine("2.Mehsulu sil");
                Console.WriteLine("3.Mehsula bax");
                Console.WriteLine("4.Tipine gore mehsullara bax");
                Console.WriteLine("5.Adina gore mehsullara bax");
                Console.WriteLine("0.EXIT");


                num = Console.ReadLine();
                switch (num)
                {
                    case "1":

                        Console.WriteLine("mehsulun adini daxil edin");
                        string name = Console.ReadLine();


                        Console.WriteLine("mehsulunu tipini daxil edin");
                        string type = Console.ReadLine();

                        string prStr;
                        double price;
                        do
                        {
                            Console.WriteLine("mehsulun qiymetin elave et");
                            prStr = Console.ReadLine();
                        }
                        while (!double.TryParse(prStr, out price));

                        Product product = new Product(name, type, price)
                        {
                            Name = name,
                            Type = type,
                            Price = price
                        };
                        store.AddProduct(product);
                        Console.Write("mehsul elave edildi:");
                        Console.WriteLine(product.ToString());



                        break;

                    case "2":
                        string noStr;
                        int no;
                        do
                        {
                            Console.WriteLine("mehsulun nomresini daxil et");
                            noStr = Console.ReadLine();
                        }
                        while (!int.TryParse(noStr, out no));
                        Product[] lastProduct = new Product[] { };
                        lastProduct = store.RemoveProductByNo(no);
                        break;


                    case "3":
                        string productNoStr;
                        int productNo;
                        do
                        {
                            Console.WriteLine("mehsulun nomresini daxil edin:");
                            productNoStr = Console.ReadLine();
                        }
                        while (!int.TryParse(productNoStr, out productNo));

                        Console.WriteLine(store.GetProduct(productNo));


                        break;
                    case "4":
                        Console.WriteLine("mehsulun tipini daxil et");
                        string productType = Console.ReadLine();
                        Product[] typeProduct = new Product[] { };
                        typeProduct = store.FilterProductsByType(productType);
                        for(int i = 0; i < typeProduct.Length; i++)
                        {
                            Console.WriteLine(typeProduct[i]);
                        }

                        break;

                    case "5":

                        Console.WriteLine("mehsulun adini daxil et");
                        string productName = Console.ReadLine();

                        Product[] nameProduct = new Product[] { };
                        nameProduct = store.FilterProductsByName(productName);
                        for(int i=0; i < nameProduct.Length; i++)
                        {
                            Console.WriteLine(nameProduct[i]);
                        }

                        break;
                    case "0":
                        check = false;
                        break;

                    default:
                        Console.WriteLine("yanlis secim");

                        break;
                }
            }
            while (check);
        }
    }
}
