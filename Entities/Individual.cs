namespace ExercMetodosAbstratos2.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpenditures)
            :base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {            
            return (AnnualIncome < 20000 ? AnnualIncome * 0.15 : AnnualIncome * 0.25) 
                - (HealthExpenditures > 0 ? HealthExpenditures * 0.5 : 0);
        }        
    }
}
