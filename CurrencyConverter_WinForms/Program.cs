using CurrencyConverter_WinForms.SaveAndLoad;
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
            MainWindow mainWindow = new MainWindow(calculator);
            JsonSerializer jsonSerializer = new JsonSerializer();
            mainWindow.Converted += jsonSerializer.OnConverted;
            mainWindow.LoadData(jsonSerializer);
            Application.Run(mainWindow);
        }
    }
}
