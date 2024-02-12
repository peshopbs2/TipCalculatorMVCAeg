using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculatorMVCAeg.Models
{
    public class Tip
    {
        public double Amount { get; set; }
        public double Percent { get; set; }

        public Tip(double amount, double percent)
        {
            Amount = amount;
            Percent = percent;
        }

        public double CalculateTip()
        {
            return Amount * Percent;
        }

        public double CalculateTotal()
        {
            return Amount + CalculateTip();
        }
    }
}
