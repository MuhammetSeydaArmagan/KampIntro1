using System;

namespace ETicaret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product  product1 = new Product();
            product1.Name = "Monitör";
            product1.Description = "144 Hz monitör";
            product1.Price = 1225.4;
            product1.SellerName = "Muhammet";

            Product product2 = new Product();
            product2.Name = "Elbise";
            product2.Description = "Saten Elbise";
            product2.Price = 12.85;
            product2.SellerName = "Merve";


            Product product3 = new Product();
            product3.Name = "Fare";
            product3.Description = "Kablosuz Mouse";
            product3.Price = 123.123;
            product3.SellerName = "Ahmet";


            Product product4 = new Product();
            product4.Name = "Yazıcı";
            product4.Description = "Wifi Yazıcı";
            product4.Price = 12.12;
            product4.SellerName = "Mehmet";

            Product[] products = new Product[] { product1, product2, product3, product4};

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Name);
                Console.WriteLine(products[i].Description);
                Console.WriteLine(products[i].Price);
                Console.WriteLine(products[i].SellerName);
                Console.WriteLine("------------");
            }
            foreach (var item in products)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.SellerName);
                Console.WriteLine("------------");
            }
            while (true)
            {
                Console.WriteLine();
            }

        




        }

        class Product
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public double Price { get; set; }
            public string SellerName { get; set; }
        }
    }
}
