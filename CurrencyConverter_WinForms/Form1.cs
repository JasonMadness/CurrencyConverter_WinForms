using CurrencyConverter_WinForms.SaveAndLoad;
using System;
using System.Text;
using System.Windows.Forms;

namespace CurrencyConverter_WinForms
{
    public partial class MainWindow : Form
    {
        #region Private Fields
        private RatesCalculator _ratesCalculator;
        private string _usd = Currencies.USD.ToString();
        private string _euro = Currencies.EUR.ToString();
        private string _yuan = Currencies.CNY.ToString();
        private string _belRub = Currencies.BYN.ToString();
        private StringBuilder _stringBuilder = new StringBuilder(50);
        #endregion
        
        public event Action<int, int, string, string> Converted;

        public MainWindow(RatesCalculator calculator)
        {
            InitializeComponent();
            _ratesCalculator = calculator;
            SetCurrencyLabels();
            SetComboBoxes();
        }

        public void LoadData(JsonSerializer jsonSerializer)
        {
            jsonSerializer.TryGetSavedData(out int myCurrenciesIndex, out int targetCurrencyIndex, out string count, out string result);
            MyCurrencies.SelectedIndex = myCurrenciesIndex;
            TargetCurrency.SelectedIndex = targetCurrencyIndex;
            textBox_count.Text = count;
            label_result.Text = result;
        }

        private void SetCurrencyLabels()
        {
            label_usd.Text = "Курс Доллара \n" + GetRate(_usd);
            label_euro.Text = "Курс Евро \n" + GetRate(_euro);
            label_yuan.Text = "Курс Юаня \n" + GetRate(_yuan);
            label_byn.Text = "Курс Белорусского Рубля \n" + GetRate(_belRub);
        }

        private string GetRate(string currencyName)
        {
            return _ratesCalculator.GetSingleRate(currencyName).ToString("F2");
        }

        private void SetComboBoxes()
        {
            MyCurrencies.Items.AddRange(Enum.GetNames(typeof(Currencies)));
            MyCurrencies.SelectedIndex = 0;
            TargetCurrency.Items.AddRange(Enum.GetNames(typeof(Currencies)));
            TargetCurrency.SelectedIndex = 1;
        }

        private void ButtonConvertClick(object sender, EventArgs e)
        {
            double result = _ratesCalculator.Calculate(MyCurrencies.Text, TargetCurrency.Text) * Convert.ToDouble(textBox_count.Text);
            label_result.Text = $"Результат: {result.ToString("F2")}";
            Converted?.Invoke(MyCurrencies.SelectedIndex, TargetCurrency.SelectedIndex, textBox_count.Text, label_result.Text);
        }

        private void TextBoxCountTextChanged(object sender, EventArgs e)
        {
            textBox_count.Text = FormatDigitInput(textBox_count.Text);
            textBox_count.SelectionStart = textBox_count.Text.Length;
        }

        private string FormatDigitInput(string input)
        {
            _stringBuilder.Clear();
            bool haveComma = false;

            foreach (char c in input)
            {
                if ((c == '.' || c == ',') && haveComma == false)
                {
                    _stringBuilder.Append(',');
                    haveComma = true;
                }
                else if (Char.IsDigit(c))
                {
                    _stringBuilder.Append(c);
                }
            }

            if ((_stringBuilder.Length > 0 && _stringBuilder[0] == ',') || _stringBuilder.Length == 0)
            {
                _stringBuilder.Insert(0, 0);
            }

            return _stringBuilder.ToString();
        }
    }
}
