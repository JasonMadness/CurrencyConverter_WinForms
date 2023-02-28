using System.Collections.Generic;

namespace CurrencyConverter_WinForms
{
    public class RatesCalculator
    {
        #region Private Fields
        private RatesParser _parser;
        private Dictionary<string, double> _rates = new Dictionary<string, double>();
        private double _rubleRate = 1;
        #endregion

        public RatesCalculator(RatesParser parser)
        {
            _parser = parser;
            SetRates();
        }

        public double Calculate(string from, string to)
        {
            return _rates[from] / _rates[to];
        }

        public double GetSingleRate(string name)
        {
            return _rates[name];
        }

        private void SetRates()
        {
            _rates.Add(Currencies.RUB.ToString(), _rubleRate);
            double baseRate = _parser.USD;
            _rates.Add(Currencies.USD.ToString(), baseRate);
            double euro = baseRate / _parser.Euro;
            _rates.Add(Currencies.EUR.ToString(), euro);
            double yuan = baseRate / _parser.Yuan;
            _rates.Add(Currencies.CNY.ToString(), yuan);
            double byn = baseRate / _parser.Byn;
            _rates.Add(Currencies.BYN.ToString(), byn);
        }
    }
}
