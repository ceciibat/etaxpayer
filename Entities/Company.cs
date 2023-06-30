using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberEmployees { get; set; }

        public Company(string name, double anualIncome, int numberEmployees) 
            : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Tax()
        {
            if(NumberEmployees > 10)
            {
                return AnualIncome * 14 / 100.0;
            }
            else
            {
                return AnualIncome * 16 / 100.0;
            }
        }
    }
}
