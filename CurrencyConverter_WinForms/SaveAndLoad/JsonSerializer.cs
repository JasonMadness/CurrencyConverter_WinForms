using System;
using System.IO;
using Newtonsoft.Json;

namespace CurrencyConverter_WinForms.SaveAndLoad
{
    public class JsonSerializer
    {
        [JsonProperty] private int _myCurrencyIndex;
        [JsonProperty] private int _targetCurrencyIndex;
        [JsonProperty] private string _countInput;
        [JsonProperty] private string _result;
        private string _path = @"savedata\";
        private int _defaultCurrencyIndex = 0;

        public void OnConverted(int myCurrencyIndex, int targetCurrencyIndex, string count, string result)
        {
            _myCurrencyIndex = myCurrencyIndex;
            _targetCurrencyIndex = targetCurrencyIndex;
            _countInput = count;
            _result = result;
            string jsonData = JsonConvert.SerializeObject(this);

            if (Directory.Exists(_path) == false)
            {
                Directory.CreateDirectory(_path);
            }

            File.WriteAllText(_path + "savedata.json", jsonData);
        }

        public void TryGetSavedData(out int myCurrencyIndex, out int targetCurrencyIndex, out string count, out string result)
        {
            if (CanGetSavedData())
            {
                JsonSerializer loadedFile = JsonConvert.DeserializeObject<JsonSerializer>(File.ReadAllText(_path + "savedata.json"));
                myCurrencyIndex = loadedFile._myCurrencyIndex;
                targetCurrencyIndex = loadedFile._targetCurrencyIndex;
                count = loadedFile._countInput;
                result = loadedFile._result;
            }
            else
            {
                myCurrencyIndex = _defaultCurrencyIndex;
                targetCurrencyIndex = _defaultCurrencyIndex;
                count = String.Empty;
                result = String.Empty;
            }
        }

        private bool CanGetSavedData() => File.Exists(_path + "savedata.json");
    }
}
