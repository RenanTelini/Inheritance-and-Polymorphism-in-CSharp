namespace Exercise04.Entities
{
    class Company : Person
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double CalcTaxes()
        {
            double percentage = 0;
            double tax = base.AnnualIncome * GetTaxPercentage(ref percentage);
            return tax;
        }

        public override double GetTaxPercentage(ref double percentage)
        {
            return percentage = (NumberOfEmployees > 10) ? 0.14 : 0.16;
        }
    }
}