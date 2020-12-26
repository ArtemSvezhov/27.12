using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConfig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBorderStyle.Text = Properties.Settings.Default.BorderStyle.ToString();
            chbMinimized.Checked = Properties.Settings.Default.minBox;
            chbMaximized.Checked = Properties.Settings.Default.maxBox;
            lblBackColor.Text = Properties.Settings.Default.bgColor.Name;
            lblfont.Text = Properties.Settings.Default.Font.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //создание переменной для записи свойств
            Properties.Settings formSettings = Properties.Settings.Default;
            //установка значений свойств
            formSettings.bgColor = this.BackColor;
            formSettings.BorderStyle = this.FormBorderStyle;
            formSettings.minBox = this.MinimizeBox;
            formSettings.maxBox = this.MaximizeBox;
            formSettings.Font = this.Font;
            //сохранение свойств
            formSettings.Save();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Process.GetCurrentProcess().Kill();
        }

        private void cmbBorderStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBorderStyle.SelectedIndex)
            {
                case 0:
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    break;
                case 1:
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                    break;
                case 2:
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
                    break;
                case 3:
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                    break;
                case 4:
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                    break;
                case 5:
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                    break;
                case 6:
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
                    break;
            }
        }

        private void chbMinimized_CheckedChanged(object sender, EventArgs e)
        {
           
                this.MinimizeBox = chbMinimized.Checked;
            
        }

        private void chbMaximized_CheckedChanged(object sender, EventArgs e)
        {
            this.MaximizeBox = chbMaximized.Checked;
        }
        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //меняем цвет формы
                this.BackColor = colorDialog1.Color;
                //выводим название цвета (или его rgb-код)
                lblBackColor.Text = colorDialog1.Color.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == fontDialog1.ShowDialog(this))
            {
                this.Font = fontDialog1.Font;
            }
        }
    }
}
