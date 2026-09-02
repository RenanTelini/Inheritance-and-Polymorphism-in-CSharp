using Exercise04.Entities;
using System.Globalization;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char response = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(response == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthcareExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    person.Add(new Individual(name, annualIncome, healthcareExpenses));
                }
                else if(response == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    person.Add(new Company(name, annualIncome, numberOfEmployees));
                }
                else
                    Console.WriteLine("Invalid option!");
            }

            double total = 0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(Person people in person)
            {
                double taxTotal = people.CalcTaxes();
                Console.WriteLine(people.Name + ": $ " + taxTotal.ToString("F2", CultureInfo.InvariantCulture));
                total += taxTotal;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: ${0}", total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}