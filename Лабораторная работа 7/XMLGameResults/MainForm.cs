using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace XMLGameResults
{
    public partial class MainForm : Form
    {
        private string filename = "A:\\Учебная практика\\25-26.12\\Лабораторная работа 7\\XMLGameResults\\Results.xml";
        public MainForm()
        {
            InitializeComponent();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            loadXml();
            btnSave.Enabled = false;
        }
        private void addPlayerToList(string id, string name, string score, string time)
        {
            //создаем новую коллекцию
            ListViewItem lvi = new ListViewItem(id);
            //заполняем ее значениями
            lvi.SubItems.Add(name);
            lvi.SubItems.Add(score);
            lvi.SubItems.Add(time);
            //вводим ее в список
            listOfPlayers.Items.Add(lvi);
        }
        private void fliterPlayers(string id, string name, string score, int MinScore, int MaxScore)
        {
            ListViewItem lvi = new ListViewItem(id);
            if (Convert.ToInt32(score) >= MinScore || Convert.ToInt32(score) <= MaxScore)
            {
                //заполняем ее значениями
                lvi.SubItems.Add(name);
                lvi.SubItems.Add(score);
            }
            //вводим ее в список
            listOfPlayers.Items.Add(lvi);
        }
        private void loadXml()
        {
            XmlDocument xmlDoc = new XmlDocument(); //создаем xml-документ
            xmlDoc.Load(filename); //загружаем документ из файла
                                   //получаем корневой элемент
            XmlElement xmlRoot = xmlDoc.DocumentElement;
            //обходим все узлы player в корневом элементе
            foreach (XmlNode xmlNode in xmlRoot)
            {
                //переменные для вывода в список
                string id = "";
                string name = "";
                string score = "";
                string time = "";
                //если узел содержит атрибуты
                if (xmlNode.Attributes.Count > 0)
                {
                    // получаем значение атрибута id
                    XmlNode attr = xmlNode.Attributes.GetNamedItem("id");
                    if (attr != null) //если атрибут не пуст
                                      //заносим его значение в соответствующую переменную
                        id = attr.Value;
                }
                // обходим все дочерние узлы элемента player
                foreach (XmlNode childNode in xmlNode.ChildNodes)
                {

                    // если узел имеет имя name
                    if (childNode.Name == "name")
                    {
                        //заносим его значение в соответствующую переменную
                        name = childNode.InnerText.ToString();
                    }
                    // если узел имеет имя score
                    if (childNode.Name == "score")
                    {
                        //заносим его значение в соответствующую переменную
                        score = childNode.InnerText.ToString();
                    }
                    if (childNode.Name == "time")
                    {
                        //заносим его значение в соответствующую переменную
                        time = childNode.InnerText.ToString();
                    }
                }
                //выводим в список информацию об игроке
                addPlayerToList(id, name, score, time);
            }
        }
        private void addToXml()
        {
            XmlDocument xmlDoc = new XmlDocument(); //создаем xml-документ
            xmlDoc.Load(filename); //загружаем данные
            XmlElement xmlRoot = xmlDoc.DocumentElement; //получаем корневой элемент
            XmlElement playerElem = xmlDoc.CreateElement("player"); // создаем новый элемент player
            // создаем его атрибут id
            XmlAttribute idAttr = xmlDoc.CreateAttribute("id");
            // создаем элементы name и score
            XmlElement nameElem = xmlDoc.CreateElement("name");
            XmlElement scoreElem = xmlDoc.CreateElement("score");
            XmlElement timeElem = xmlDoc.CreateElement("time");
            // создаем текстовые значения для элементов и атрибута
            //id=количество узлов в корневом узле + 1
            XmlText idText = xmlDoc.CreateTextNode((xmlRoot.ChildNodes.Count + 1).ToString());
            XmlText nameText = xmlDoc.CreateTextNode(txtName.Text);
            XmlText scoreText = xmlDoc.CreateTextNode(txtScore.Text);
            XmlText timeText = xmlDoc.CreateTextNode(txtTime.Text);
            //присваиваем текстовые значения в атрибут и элементы
            idAttr.AppendChild(idText);
            nameElem.AppendChild(nameText);
            scoreElem.AppendChild(scoreText);
            timeElem.AppendChild(timeText);
            //добавляем атрибут и элементы в узел player
            playerElem.Attributes.Append(idAttr);
            playerElem.AppendChild(nameElem);
            playerElem.AppendChild(scoreElem);
            playerElem.AppendChild(timeElem);
            //добаваляем в корневой узел новый узел player
            xmlRoot.AppendChild(playerElem);
            //сохраняем изменения
            xmlDoc.Save(filename);
            //выводим в список новую строку
            string id = (xmlRoot.ChildNodes.Count + 1).ToString();
            string name = txtName.Text;
            string score = txtScore.Text;
            string time = txtTime.Text;
            addPlayerToList(id, name, score, time);
        }
        private void txtScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != null && txtScore.Text != null && txtTime.Text != null)
                btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addToXml();
            txtName.Clear();
            txtScore.Clear();
            txtTime.Clear();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // int MinScore = Convert.ToInt32(txtMinScore.Text);
            //  int MaxScore = Convert.ToInt32(txtMaxScore.Text);
            MessageBox.Show("Функционал не завезли,приходите позже");
        }
    }
}
