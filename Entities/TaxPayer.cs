using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix.Entities
{
    abstract class TaxPayer  // Contribuínte
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
