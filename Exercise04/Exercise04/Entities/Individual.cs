namespace Exercise04.Entities
{
    class Individual : Person
    {
        public double HealthcareExpenses { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double annualIncome, double healthcareExpenses) 
            : base(name, annualIncome)
        {
            HealthcareExpenses = healthcareExpenses;
        }

        public override double CalcTaxes()
        {
            double percentage = 0;
            double tax = (base.AnnualIncome * GetTaxPercentage(ref percentage) - (HealthcareExpenses * CheckHealthcareExpensesDiscount()));
            return tax;
        }

        public override double GetTaxPercentage(ref double percentage)
        {
            if (base.AnnualIncome >= 20000.00)
                return percentage = 0.25;
            else
                return percentage = 0.15;
        }

        public double CheckHealthcareExpensesDiscount()
        {
            return (HealthcareExpenses > 0) ? 0.5 : 0;
        }
    }
}