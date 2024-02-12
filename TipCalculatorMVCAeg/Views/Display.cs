using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculatorMVCAeg.Views
{
    public class Display
    {
        public double Amount { get; set; }
        public double Percent { get; set; }
        public double TipAmount { get; set; }
        public double Total { get; set; }

        public Display()
        {
            GetValues();
        }
        
        public void GetValues()
        {
            Console.WriteLine("Enter amount: ");
            Amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter percent (ex: 0.01):");
            Percent = double.Parse(Console.ReadLine());
        }

        public void DisplayResult()
        {

            Console.WriteLine($"Tip: {TipAmount:F2}$");
            Console.WriteLine($"Total: {Total:F2}$");
        }
    }
}
