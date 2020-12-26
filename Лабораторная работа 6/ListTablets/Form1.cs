using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ListTablets
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tslCount.Text = "Записей не существует";
        }
        private string filename = "tablets.dat"; //имя рабочего файла
        private List<Tablet> Tablets = new List<Tablet>();//список планшетов(объектов Tablet)
        private int current = 0; //номер текущей записи, нумерация начинается с 0 

        private void AddTablet()
        {
            Tablet buf = new Tablet(); //создаем новый объект
                                       //заполняем строковый массив значчениями из полей ввода
            string[] TabletInfo = new string[6];
            TabletInfo[0] = tbModel.Text;
            TabletInfo[1] = tbDiagonal.Text;
            TabletInfo[2] = tbOS.Text;
            TabletInfo[3] = tbMemory.Text;
            TabletInfo[4] = tbStorage.Text;
            TabletInfo[5] = tbCPU.Text;
            buf.SetStringValues(TabletInfo); //заносим значения в объект
            Tablets.Add(buf); //добавляем объект в список
        }

        private void SaveFile()
        {
            //создаем объект, выполняющий сериализацию
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                //создаем файловый поток для записи
                using (FileStream fs = new FileStream(filename,
                FileMode.OpenOrCreate, FileAccess.Write))
                {
                    bf.Serialize(fs, Tablets); //сериализуем список
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ошибка ввода-вывода: " + ex.ToString());
            }
            catch (SerializationException ex)
            {
                MessageBox.Show("Ошибка сериализации: " + ex.ToString());
            }
        }
        private void TabletToTextBoxes(int current)
        {
            if (Tablets.Count > 0)//если список не пуст
            {
                //получаем строковые значения полей объекта (текущей записи из списка)
                string[] TabletInfo = Tablets[current].GetStringValues();
                //выводим эти значения в соответствующие текстовые поля
                tbModel.Text = TabletInfo[0];
                tbDiagonal.Text = TabletInfo[1];
                tbOS.Text = TabletInfo[2];
                tbMemory.Text = TabletInfo[3];
                tbStorage.Text = TabletInfo[4];
                tbCPU.Text = TabletInfo[5];
            }
            else //иначе считаем, что записей для отображения нет
            {
                //очищаем поля ввода
                tbModel.Clear();
                tbDiagonal.Clear();
                tbOS.Clear();
                tbMemory.Clear();
                tbStorage.Clear();
                tbCPU.Clear();
            }
        }
        private void ScrollTablet(sbyte inc)
        {
            //inc - значение, на которое нужно изменить номер текущей записи
            //может принимать значения 1 и -1
            //если полученный номер записи больше нуля и меньше общего количества записей
            if ((current + inc <= Tablets.Count - 1) && (current + inc >= 0))
            {
                current += inc; //изменяем номер текущей записи
                TabletToTextBoxes(current); //отображаем эту запись
            }
        }
        private void DeleteTablet()
        {
            Tablets.RemoveAt(current); //удаляем значение из списка по его номеру
            if (current > 0) //если удалялась не первая запись
                current--; //делаем текущей предыдущую
        }

             private void tsbAdd_Click_1(object sender, EventArgs e)
        {
            //очищаем поля ввода
            tbModel.Clear();
            tbDiagonal.Clear();
            tbOS.Clear();
            tbMemory.Clear();
            tbStorage.Clear();
            tbCPU.Clear();
            //отображаем кнопки
            btnSave.Visible = true;
            btnCancel.Visible = true;
            if (Tablets.Count <= 0)
                tslCount.Text = "Записей не существует";
            else
                tslCount.Text = "Количество записей " + Tablets.Count;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            // N += 1;
            AddTablet(); //добавляем запись в список
            SaveFile(); //сохраняем изменения в файле
            current = Tablets.Count - 1; //текущей записью становится последняя в списке

            //выключаем кнопки
            btnSave.Visible = false;
            btnCancel.Visible = false;
            MessageBox.Show("Запись добавлена");
            if (Tablets.Count <= 0)
                tslCount.Text = "Записей не существует";
            else
                tslCount.Text = "Количество записей " + Tablets.Count;
        }
        private void tsbPrev_Click(object sender, EventArgs e)
        {
            ScrollTablet(-1);
        }
        private void tsbNext_Click(object sender, EventArgs e)
        {
            ScrollTablet(1);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //выключаем "кнопки"
            btnSave.Visible = false;
            btnCancel.Visible = false;
            TabletToTextBoxes(current); //отображаем текущую запись 
        }
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (Tablets.Count > 0) //если список не пуст
            {
                DeleteTablet(); //удаляем запись
                                //если после удаления в списке не осталось значений
                if (Tablets.Count == 0)
                {
                    //очищаем текстовые поля
                    tbModel.Clear();
                    tbDiagonal.Clear();
                    tbOS.Clear();
                    tbMemory.Clear();
                    tbStorage.Clear();
                    tbCPU.Clear();
                }
                else
                {
                    TabletToTextBoxes(current); //выводим информацию о текущей записи
                }
                SaveFile(); //сохраняем изменения
                if (Tablets.Count <= 0)
                    tslCount.Text = "Записей не существует";
                else
                    tslCount.Text = "Количество записей " + Tablets.Count;
                MessageBox.Show("Запись удалена");

            }
        }
    }
}
