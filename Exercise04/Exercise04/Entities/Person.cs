namespace Exercise04.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Person()
        {
        }

        public Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double CalcTaxes();
        public abstract double GetTaxPercentage(ref double percentage);
    }
}