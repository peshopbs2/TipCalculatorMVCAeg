using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipCalculatorMVCAeg.Models;
using TipCalculatorMVCAeg.Views;

namespace TipCalculatorMVCAeg.Controllers
{
    internal class CalculatorTipController
    {
        private Tip tip;
        private Display display;
        public CalculatorTipController() {
            Display display= new Display();
            Tip tip = new Tip(display.Amount, display.Percent);
            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();

            display.DisplayResult();
        }

    }
}
