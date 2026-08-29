using System.Globalization;
using Exercise02.Entities;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Commom, used or imported (c/u/i): ");
                char response = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(response == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if(response == 'c')
                {
                    products.Add(new Product(name, price));
                }
                else if(response == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                    Console.Write("Enter a valid, character, character entered " + response);
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product prod in products)
            { 
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}