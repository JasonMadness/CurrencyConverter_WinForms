using System;
using System.Windows.Forms;

namespace CurrencyConverter_WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RatesParser parser = new RatesParser();
            parser.GetRates();
            RatesCalculator calculator = new RatesCalculator(parser);
            Application.Run(new MainWindow(calculator));
        }
    }
}
