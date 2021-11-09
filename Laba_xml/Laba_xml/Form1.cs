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
using System.Xml.Xsl;
using System.IO;

namespace Laba_xml
{
    public partial class Form1 : Form
    {        
        IAnalizatorXMLStrategy strategy = new AnalizatorXMLDOMStrategy();
        TextBox FileName = new TextBox();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetDorms();     
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

 
        private void Clear(object sender, EventArgs e)
        {
            Results.Text = "";
            checkBoxName.Checked = false;
            checkBoxYear.Checked = false;
            checkBoxRoom.Checked = false;
            checkBoxCathedra.Checked = false;
            checkBoxFaculty.Checked = false;
            checkBoxInDate.Checked = false;
            checkBoxInDate.Checked = false;
            checkBoxDormNumber.Checked = false;
            comboBoxName.Text = "";
            comboBoxSurname.Text = "";
            comboBoxPatronymic.Text = "";
            comboBoxInDate.Text = "";
            comboBoxOutDate.Text = "";
            comboBoxRoom.Text = "";
            comboBoxYear.Text = "";
            comboBoxCathedra.Text = "";
            comboBoxFaculty.Text = "";
            comboBoxDormNumber.Text = "";
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {

        }
        public void GetDorms()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Nata\Desktop\уник\ООП\Laba_xml\Laba_xml\XMLFile1.xml");
            XmlElement xRoot = doc.DocumentElement;
            XmlNodeList childNodes = xRoot.SelectNodes("Dormitory");

            for (int i = 0; i < childNodes.Count; ++i)
            {
                XmlNode dorm = childNodes.Item(i);
                if (!comboBoxDormNumber.Items.Contains(dorm.SelectSingleNode("@Number").Value))
                    comboBoxDormNumber.Items.Add(dorm.SelectSingleNode("@Number").Value);
                XmlNodeList students = dorm.SelectNodes("Student");
                for (int j = 0; j < students.Count; ++j)
                {
                    XmlNode n = students.Item(j);
                    AddItems(n);
                }
            }
        }

        public void AddItems(XmlNode n)
        {
            if (!comboBoxName.Items.Contains(n.SelectSingleNode("@Name").Value))
                comboBoxName.Items.Add(n.SelectSingleNode("@Name").Value);
            if (!comboBoxSurname.Items.Contains(n.SelectSingleNode("@Surname").Value))
                comboBoxSurname.Items.Add(n.SelectSingleNode("@Surname").Value);
            if (!comboBoxPatronymic.Items.Contains(n.SelectSingleNode("@Patronymic").Value))
                comboBoxPatronymic.Items.Add(n.SelectSingleNode("@Patronymic").Value);
            if (!comboBoxYear.Items.Contains(n.SelectSingleNode("@Year").Value))
                comboBoxYear.Items.Add(n.SelectSingleNode("@Year").Value);
            if (!comboBoxFaculty.Items.Contains(n.SelectSingleNode("@Faculty").Value))
                comboBoxFaculty.Items.Add(n.SelectSingleNode("@Faculty").Value);
            if (!comboBoxCathedra.Items.Contains(n.SelectSingleNode("@Cathedra").Value))
                comboBoxCathedra.Items.Add(n.SelectSingleNode("@Cathedra").Value);
            if (!comboBoxRoom.Items.Contains(n.SelectSingleNode("@Room").Value))
                comboBoxRoom.Items.Add(n.SelectSingleNode("@Room").Value);
            if (!comboBoxInDate.Items.Contains(n.SelectSingleNode("@InDate").Value))
                comboBoxInDate.Items.Add(n.SelectSingleNode("@InDate").Value);
            if (!comboBoxOutDate.Items.Contains(n.SelectSingleNode("@OutDate").Value))
                comboBoxOutDate.Items.Add(n.SelectSingleNode("@OutDate").Value);
        }


        private void Search(object sender, EventArgs e)
        {
            Results.Text = "";
            Student sample = new Student();
            if (checkBoxName.Checked)
            {
                sample.name = Convert.ToString(comboBoxName.SelectedItem);
                sample.surname = Convert.ToString(comboBoxSurname.SelectedItem);
                sample.patronymic = Convert.ToString(comboBoxPatronymic.SelectedItem);
            }
            if (checkBoxYear.Checked) sample.year = Convert.ToString(comboBoxYear.SelectedItem);
            if (checkBoxFaculty.Checked) sample.faculty = Convert.ToString(comboBoxFaculty.SelectedItem);
            if (checkBoxCathedra.Checked) sample.cathedra = Convert.ToString(comboBoxCathedra.SelectedItem);
            if (checkBoxRoom.Checked) sample.room = Convert.ToString(comboBoxRoom.SelectedItem);
            if (checkBoxDormNumber.Checked) sample.dorm = Convert.ToString(comboBoxDormNumber.SelectedItem);
            if (checkBoxInDate.Checked) sample.in_date = Convert.ToString(comboBoxInDate.SelectedItem);
            if (checkBoxOutDate.Checked) sample.out_date = Convert.ToString(comboBoxOutDate.SelectedItem);

            List<Dormitory> Dorms = strategy.Search(sample);
            //Results.Text = "";
            for (int i = 0; i < Dorms.Count; ++i)
            {
                Results.Text += "Гуртожиток №" + Convert.ToString(Dorms[i].number) + "\n";
                for (int j = 0; j < Dorms[i].studentsList.Count; ++j)
                {
                    Results.Text += "\t" + "Студент: " + 
                        Dorms[i].studentsList[j].surname + " " + 
                        Dorms[i].studentsList[j].name + " " + 
                        Dorms[i].studentsList[j].patronymic + "\n";
                    Results.Text += "\t" + "Курс:  " + Dorms[i].studentsList[j].year + "\n";
                    Results.Text += "\t" + "Факультет: " + Dorms[i].studentsList[j].faculty + "\n";
                    Results.Text += "\t" + "Кафедра: " + Dorms[i].studentsList[j].cathedra + "\n";
                    Results.Text += "\t" + "Кімната: " + Dorms[i].studentsList[j].room + "\n";
                    Results.Text += "\t" + "Дати проживання: " + 
                        Dorms[i].studentsList[j].in_date + " - " + 
                        Dorms[i].studentsList[j].out_date + "\n";
                    Results.Text += "\n";
                }
                
            }

        }

        private void radioButtonDOM_Click(object sender, EventArgs e)
        {
            strategy = new AnalizatorXMLDOMStrategy();
        }

        private void radioButtonSAX_Click(object sender, EventArgs e)
        {
            strategy = new AnalizatorXMLSAXStrategy();
        }

        private void radioButtonLINQ_Click(object sender, EventArgs e)
        {
            strategy = new AnalizatorXMLLINQStrategy();
        }

        private void ConvertToHTML(object sender, EventArgs e)
        {
            string path = Microsoft.VisualBasic.Interaction.InputBox("Зберегти файл з назвою:");
            if (path.Length == 0) { 
                MessageBox.Show("Конвертація скасована");
                return;
            }
            path = "C:\\Users\\Nata\\Desktop\\уник\\ООП\\Laba_xml\\Laba_xml\\" + path + ".html";
            if (File.Exists(@path))
            {
                DialogResult res = MessageBox.Show("Файл з такою назвою вже існує\n Замінити існуючий файл?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.No)
                {
                    MessageBox.Show("Конвертація скасована");
                    return;
                }
            }

            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load(@"C:\Users\Nata\Desktop\уник\ООП\Laba_xml\Laba_xml\XSLFile1.xsl");
            string fXML = @"C:\Users\Nata\Desktop\уник\ООП\Laba_xml\Laba_xml\XMLFile1.xml";
            string fHTML = @path;

            try { 
                xct.Transform(fXML, fHTML); 
            }
            catch
            {
                MessageBox.Show("Некоректне ім'я файлу\nКонвертація скасована");
                return;
            }
            MessageBox.Show("Файл конвертовано і збережено в директорії проєкту");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show("Ви впевненні, що хочете закрити файл?\nУсі незбережені данні буде втрачено", 
                "Закриття",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) e.Cancel = true;
        }

    }
}
