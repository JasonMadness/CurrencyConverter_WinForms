using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter_WinForms
{
    public class RatesParser
    {
        #region Private Fields
        private string _webPageText;
        private double _usd;
        private double _euro;
        private double _yuan;
        private double _byn;
        #endregion

        #region Public Properties
        public double USD => _usd;
        public double Euro => _euro;
        public double Yuan => _yuan;
        public double Byn => _byn;
        #endregion

        public void GetRates()
        {
            WebClient webClient = new WebClient();
            _webPageText = webClient.DownloadString("https://ru.myfin.by/converter?conv_rub=1");
            string baseRate = GetCurrencyName((int)Currencies.RUB);
            _usd = GetRateByName(baseRate);
            string euro = GetCurrencyName((int)(Currencies.EUR));
            _euro = GetRateByName(euro);
            string yuan = GetCurrencyName((int)(Currencies.CNY));
            _yuan = GetRateByName(yuan);
            string byn = GetCurrencyName((int)(Currencies.BYN));
            _byn = GetRateByName(byn);
        }

        private string GetCurrencyName(int enumIndex)
        {
            return Enum.GetName(typeof(Currencies), enumIndex).ToLower();
        }

        private double GetRateByName(string currencyName)
        {
            string rate = Regex.Match(_webPageText, $@"id=""conv_{currencyName}"" name=""conv_{currencyName}"" class=""form-control coverter-cbrf currency_inp"" value=""([0-9]*\.[0-9]*)""").Groups[1].Value.Replace('.', ',');
            return Convert.ToDouble(rate);
        }
    }
}
