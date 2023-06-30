using Fix.Entities;
using System.Globalization;

namespace Fix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, expenditures));
                }
                else if(type == 'c')
                {
                    Console.Write("Number of employees: ");
                    int number = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, number));
                }
                else
                {
                    Console.WriteLine("This type doesn't exist! Try again");
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double sum = 0.0;
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.Tax().ToString("f2", CultureInfo.InvariantCulture));

                sum = sum + taxPayer.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
