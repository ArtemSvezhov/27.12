
namespace AppConfig
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblBackColor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.chbMaximized = new System.Windows.Forms.CheckBox();
            this.chbMinimized = new System.Windows.Forms.CheckBox();
            this.cmbBorderStyle = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblfont = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(196, 227);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(94, 20);
            this.lblBackColor.TabIndex = 17;
            this.lblBackColor.Text = "Цвет фона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Цвет фона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Кнопки строки заголовка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Стиль рамки";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(490, 336);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 35);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(339, 220);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(122, 35);
            this.btnChangeColor.TabIndex = 12;
            this.btnChangeColor.Text = "Изменить";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // chbMaximized
            // 
            this.chbMaximized.AutoSize = true;
            this.chbMaximized.Location = new System.Drawing.Point(275, 163);
            this.chbMaximized.Name = "chbMaximized";
            this.chbMaximized.Size = new System.Drawing.Size(143, 24);
            this.chbMaximized.TabIndex = 11;
            this.chbMaximized.Text = "Восстановить";
            this.chbMaximized.UseVisualStyleBackColor = true;
            this.chbMaximized.CheckedChanged += new System.EventHandler(this.chbMaximized_CheckedChanged);
            // 
            // chbMinimized
            // 
            this.chbMinimized.AutoSize = true;
            this.chbMinimized.Location = new System.Drawing.Point(275, 120);
            this.chbMinimized.Name = "chbMinimized";
            this.chbMinimized.Size = new System.Drawing.Size(107, 24);
            this.chbMinimized.TabIndex = 10;
            this.chbMinimized.Text = "Свернуть";
            this.chbMinimized.UseVisualStyleBackColor = true;
            this.chbMinimized.CheckedChanged += new System.EventHandler(this.chbMinimized_CheckedChanged);
            // 
            // cmbBorderStyle
            // 
            this.cmbBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBorderStyle.FormattingEnabled = true;
            this.cmbBorderStyle.Items.AddRange(new object[] {
            "Рамка отсутствует;",
            "Фиксированная однострочная граница;",
            "Фиксированная трехмерная граница;",
            "В стиле диалоговых окон;",
            "Изменяемая граница;",
            "Не изменяемая граница окна настроек;",
            "Изменяемая граница окна настроек."});
            this.cmbBorderStyle.Location = new System.Drawing.Point(275, 41);
            this.cmbBorderStyle.Name = "cmbBorderStyle";
            this.cmbBorderStyle.Size = new System.Drawing.Size(303, 28);
            this.cmbBorderStyle.TabIndex = 9;
            this.cmbBorderStyle.SelectedIndexChanged += new System.EventHandler(this.cmbBorderStyle_SelectedIndexChanged);
            // 
            // lblfont
            // 
            this.lblfont.AutoSize = true;
            this.lblfont.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblfont.Location = new System.Drawing.Point(145, 283);
            this.lblfont.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblfont.Name = "lblfont";
            this.lblfont.Size = new System.Drawing.Size(64, 20);
            this.lblfont.TabIndex = 19;
            this.lblfont.Text = "Шрифт";
            this.lblfont.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Шрифт";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::AppConfig.Properties.Settings.Default.bgColor;
            this.ClientSize = new System.Drawing.Size(664, 392);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblfont);
            this.Controls.Add(this.lblBackColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.chbMaximized);
            this.Controls.Add(this.chbMinimized);
            this.Controls.Add(this.cmbBorderStyle);
            this.DataBindings.Add(new System.Windows.Forms.Binding("FormBorderStyle", global::AppConfig.Properties.Settings.Default, "BorderStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("MinimizeBox", global::AppConfig.Properties.Settings.Default, "minBox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("MaximizeBox", global::AppConfig.Properties.Settings.Default, "maxBox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AppConfig.Properties.Settings.Default, "bgColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AppConfig.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::AppConfig.Properties.Settings.Default.Font;
            this.FormBorderStyle = global::AppConfig.Properties.Settings.Default.BorderStyle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = global::AppConfig.Properties.Settings.Default.maxBox;
            this.MinimizeBox = global::AppConfig.Properties.Settings.Default.minBox;
            this.Name = "Form1";
            this.Text = "Установка параметров окна";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBackColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.CheckBox chbMaximized;
        private System.Windows.Forms.CheckBox chbMinimized;
        private System.Windows.Forms.ComboBox cmbBorderStyle;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblfont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

