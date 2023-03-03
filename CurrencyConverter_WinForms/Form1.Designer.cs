namespace CurrencyConverter_WinForms
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_usd = new System.Windows.Forms.Label();
            this.label_euro = new System.Windows.Forms.Label();
            this.label_yuan = new System.Windows.Forms.Label();
            this.label_byn = new System.Windows.Forms.Label();
            this.label_header = new System.Windows.Forms.Label();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.label_youHave = new System.Windows.Forms.Label();
            this.MyCurrencies = new System.Windows.Forms.ComboBox();
            this.label_convertIn = new System.Windows.Forms.Label();
            this.TargetCurrency = new System.Windows.Forms.ComboBox();
            this.label_result = new System.Windows.Forms.Label();
            this.button_convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_usd
            // 
            this.label_usd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_usd.Location = new System.Drawing.Point(12, 61);
            this.label_usd.Name = "label_usd";
            this.label_usd.Size = new System.Drawing.Size(208, 84);
            this.label_usd.TabIndex = 2;
            this.label_usd.Text = "Курс Доллара: ";
            this.label_usd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_euro
            // 
            this.label_euro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_euro.Location = new System.Drawing.Point(12, 145);
            this.label_euro.Name = "label_euro";
            this.label_euro.Size = new System.Drawing.Size(208, 84);
            this.label_euro.TabIndex = 3;
            this.label_euro.Text = "Курс Евро: ";
            this.label_euro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_yuan
            // 
            this.label_yuan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_yuan.Location = new System.Drawing.Point(12, 229);
            this.label_yuan.Name = "label_yuan";
            this.label_yuan.Size = new System.Drawing.Size(208, 84);
            this.label_yuan.TabIndex = 4;
            this.label_yuan.Text = "Курс Юаня: ";
            this.label_yuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_byn
            // 
            this.label_byn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_byn.Location = new System.Drawing.Point(12, 313);
            this.label_byn.Name = "label_byn";
            this.label_byn.Size = new System.Drawing.Size(208, 84);
            this.label_byn.TabIndex = 5;
            this.label_byn.Text = "Курс Беларусского Рубля: ";
            this.label_byn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_header
            // 
            this.label_header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_header.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_header.Location = new System.Drawing.Point(275, 10);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(200, 50);
            this.label_header.TabIndex = 6;
            this.label_header.Text = "КУРСЫ ВАЛЮТ";
            this.label_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(569, 129);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(100, 20);
            this.textBox_count.TabIndex = 7;
            this.textBox_count.Text = "1";
            this.textBox_count.TextChanged += new System.EventHandler(this.TextBoxCountTextChanged);
            // 
            // label_youHave
            // 
            this.label_youHave.AutoSize = true;
            this.label_youHave.Location = new System.Drawing.Point(523, 132);
            this.label_youHave.Name = "label_youHave";
            this.label_youHave.Size = new System.Drawing.Size(40, 13);
            this.label_youHave.TabIndex = 8;
            this.label_youHave.Text = "У Вас:";
            // 
            // MyCurrencies
            // 
            this.MyCurrencies.FormattingEnabled = true;
            this.MyCurrencies.Location = new System.Drawing.Point(675, 129);
            this.MyCurrencies.Name = "MyCurrencies";
            this.MyCurrencies.Size = new System.Drawing.Size(64, 21);
            this.MyCurrencies.TabIndex = 9;
            // 
            // label_convertIn
            // 
            this.label_convertIn.AutoSize = true;
            this.label_convertIn.Location = new System.Drawing.Point(523, 182);
            this.label_convertIn.Name = "label_convertIn";
            this.label_convertIn.Size = new System.Drawing.Size(74, 13);
            this.label_convertIn.TabIndex = 10;
            this.label_convertIn.Text = "Перевести в:";
            // 
            // TargetCurrency
            // 
            this.TargetCurrency.FormattingEnabled = true;
            this.TargetCurrency.Location = new System.Drawing.Point(675, 179);
            this.TargetCurrency.Name = "TargetCurrency";
            this.TargetCurrency.Size = new System.Drawing.Size(64, 21);
            this.TargetCurrency.TabIndex = 11;
            // 
            // label_result
            // 
            this.label_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_result.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.Location = new System.Drawing.Point(569, 333);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(125, 81);
            this.label_result.TabIndex = 12;
            this.label_result.Text = "Результат:";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(569, 261);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(125, 52);
            this.button_convert.TabIndex = 13;
            this.button_convert.Text = "Сконвертировать";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.ButtonConvertClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.TargetCurrency);
            this.Controls.Add(this.label_convertIn);
            this.Controls.Add(this.MyCurrencies);
            this.Controls.Add(this.label_youHave);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.label_header);
            this.Controls.Add(this.label_byn);
            this.Controls.Add(this.label_yuan);
            this.Controls.Add(this.label_euro);
            this.Controls.Add(this.label_usd);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертер валют";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_usd;
        private System.Windows.Forms.Label label_euro;
        private System.Windows.Forms.Label label_yuan;
        private System.Windows.Forms.Label label_byn;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.Label label_youHave;
        private System.Windows.Forms.ComboBox MyCurrencies;
        private System.Windows.Forms.Label label_convertIn;
        private System.Windows.Forms.ComboBox TargetCurrency;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button_convert;
    }
}

