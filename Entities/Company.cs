namespace ExercMetodosAbstratos2.Entities
{
    internal class Company : TaxPayer
    {
        public int EmployeeQtty { get; set; }

        public Company(string name, double annualIncome, int employeeQtty) : base(name, annualIncome)
        {
            EmployeeQtty = employeeQtty;
        }

        public override double Tax()
        {
            return (EmployeeQtty > 10 ? AnnualIncome * 0.14 : AnnualIncome * 0.16);
        }
    }
}
