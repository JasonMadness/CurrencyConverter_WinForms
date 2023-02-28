using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CurrencyConverter_WinForms
{
    public partial class Form1 : Form
    {
        private RatesCalculator _ratesCalculator;
        private string _usd = Currencies.USD.ToString();
        private string _euro = Currencies.EUR.ToString();
        private string _yuan = Currencies.CNY.ToString();
        private string _belRub = Currencies.BYN.ToString();
        StringBuilder _stringBuilder = new StringBuilder(50);

        public Form1(RatesCalculator calculator)
        {
            InitializeComponent();
            _ratesCalculator = calculator;
            SetCurrencyLabels();
            SetComboBoxes();            
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

        private void button_convert_Click(object sender, EventArgs e)
        {
            double result = _ratesCalculator.Calculate(MyCurrencies.Text, TargetCurrency.Text) * Convert.ToDouble(textBox_count.Text);
            label_result.Text = $"Результат: {result.ToString("F4")}";
        }

        private void textBox_count_TextChanged(object sender, EventArgs e)
        {
            textBox_count.Text = FormatDigitInput(textBox_count.Text);
            textBox_count.SelectionStart = textBox_count.Text.Length;
        }

        private string FormatDigitInput(string input)
        {
            _stringBuilder.Clear();
            foreach (char c in input)
            {
                if (c == '.')
                {
                    _stringBuilder.Append(',');
                }
                else
                {
                    _stringBuilder.Append(c);
                }
            }

            return _stringBuilder.ToString();
        }
    }
}
