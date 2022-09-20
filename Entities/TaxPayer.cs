using System.Globalization;

namespace ExercMetodosAbstratos2.Entities
{
    internal abstract class TaxPayer
    {        
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public TaxPayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();        
    }
}
