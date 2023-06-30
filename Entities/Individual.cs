using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) 
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 15 / 100.0 - HealthExpenditures * 50 / 100.0;
            }
            else
            {
                return AnualIncome * 25 / 100.0 - HealthExpenditures * 50 / 100.0;
            }
        }
    }
}
