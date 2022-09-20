using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;
using ExercMetodosAbstratos2.Entities;

namespace ExercMetodosAbstratos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<TaxPayer> lstTxPayer = new List<TaxPayer>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i / c)? ");
                Char typeShape = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (typeShape == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lstTxPayer.Add(new Individual(name, annualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employeeQtty = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lstTxPayer.Add(new Company(name, annualIncome, employeeQtty));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double totalTaxes = 0;
            foreach (TaxPayer taxPayer in lstTxPayer)
            {
                double tax = taxPayer.Tax();
                totalTaxes += taxPayer.Tax();
                Console.WriteLine(taxPayer.Name 
                    + ": $" 
                    + tax.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
