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
using System.Web;

namespace Laba2
{
    public partial class Form1 : Form
    {
        bool flag = true;
        string path = @"C:\Users\Gleb\source\repos\Laba2\Laba2\CarSales.xml";
        string finalPath = @"C:\Users\Gleb\source\repos\Laba2\Laba2\FinalCarSales.xml";
        string htmlPath = @"C:\Users\Gleb\source\repos\Laba2\Laba2\bin\Debug\netcoreapp3.1\inf.html";
        List<CarSale> final = new List<CarSale>();
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllSales();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void GetAllSales()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlElement xRoot = doc.DocumentElement;
            XmlNodeList childNodes = xRoot.SelectNodes("Car");

            for (int i = 0; i < childNodes.Count; i++)
            {
                XmlNode n = childNodes.Item(i);
                addItems(n);
            }

            string cheapPrice = "до 10000";
            string mediumPrice = "10000-30000";
            string highPrice = "30000-60000";
            string veryHighPrice = "60000+";

            string oldYear = "до 2010";
            string mediumYear = "2010-2015";
            string newYear = "2015-2020";

            comboBoxPrice.Items.Add(cheapPrice);
            comboBoxPrice.Items.Add(mediumPrice);
            comboBoxPrice.Items.Add(highPrice);
            comboBoxPrice.Items.Add(veryHighPrice);

            comboBoxRegion.Items.Add("Київ");
            comboBoxRegion.Items.Add("Одеса");
            comboBoxRegion.Items.Add("Харків");
            comboBoxRegion.Items.Add("Херсон");
            comboBoxRegion.Items.Add("Львів");
            comboBoxRegion.Items.Add("Дніпро");

            comboBoxYear.Items.Add(oldYear);
            comboBoxYear.Items.Add(mediumYear);
            comboBoxYear.Items.Add(newYear);
        }

        private void addItems(XmlNode n)
        {
            if (!comboBoxBody.Items.Contains(n.SelectSingleNode("@Body").Value))
                comboBoxBody.Items.Add(n.SelectSingleNode("@Body").Value);

            if (!comboBoxBrand.Items.Contains(n.SelectSingleNode("@Brand").Value))
                comboBoxBrand.Items.Add(n.SelectSingleNode("@Brand").Value);

            /*if (!comboBoxModel.Items.Contains(n.SelectSingleNode("@Model").Value))
                comboBoxModel.Items.Add(n.SelectSingleNode("@Model").Value);*/
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!flag) flag = !flag;
            if (flag)
            {
                comboBoxModel.Enabled = true;
                flag = !flag;
            }
            RefreshModels();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Ви впевнені, цо бажаєте вийти?", "Повідомлення", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation))
            {
                //Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void comboBoxBrand_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            rtb.Clear();
            checkBoxBody.Checked = false;
            checkBoxBrand.Checked = false;
            checkBoxModel.Checked = false;
            checkBoxRegion.Checked = false;
            checkBoxYear.Checked = false;
            DOMradioButton.Checked = false;
            LINQradioButton.Checked = false;
            SAXradioButton.Checked = false;
            comboBoxBody.Text = null;
            comboBoxBrand.Text = null;
            comboBoxModel.Text = null;
            comboBoxModel.Enabled = false;
            comboBoxPrice.Text = null;
            comboBoxRegion.Text = null;
            comboBoxYear.Text = null;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            rtb.Clear();
            CarSale carSale = OurCarSale();
            IStrategy CurrentStrategy;
            if (LINQradioButton.Checked)
            {
                CurrentStrategy = new Linq(path);
                final = CurrentStrategy.Algorithm(carSale, path);
                Output(final);
            }
            else if (DOMradioButton.Checked)
            {
                CurrentStrategy = new Dom(path);
                final = CurrentStrategy.Algorithm(carSale, path);
                Output(final);
            }
            else if (SAXradioButton.Checked)
            {
                CurrentStrategy = new Sax();
                final = CurrentStrategy.Algorithm(carSale, path);
                Output(final);
            }
        }

        private CarSale OurCarSale()
        {
                CarSale cs = new CarSale();
                if (checkBoxBody.Checked)cs.Body = comboBoxBody.SelectedItem.ToString();
                if (checkBoxBrand.Checked) cs.Brand = comboBoxBrand.SelectedItem.ToString();
                if (checkBoxModel.Checked) cs.Model = comboBoxModel.SelectedItem.ToString();
                if (checkBoxRegion.Checked) cs.Region = comboBoxRegion.SelectedItem.ToString();
                if (checkBoxYear.Checked) cs.Year = comboBoxYear.SelectedItem.ToString();
                if (checkBoxPrice.Checked) cs.Price = comboBoxPrice.SelectedItem.ToString();
                return cs;
        }

        private void Output(List<CarSale> final)
        {
            foreach(CarSale cs in final)
            {
                rtb.Text += "Кузов: " + cs.Body + "\n";
                rtb.Text += "Марка: " + cs.Brand + "\n";
                rtb.Text += "Модель: " + cs.Model + "\n";
                rtb.Text += "Місто продажу: " + cs.Region + "\n";
                rtb.Text += "Рік випуску: " + cs.Year + "\n";
                rtb.Text += "Ціна: " + cs.Price + "\n";

                rtb.Text+="\n\n";
            }
        }

        private void transformingButton_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load("XSL.xsl");
            string output = @"inf.html";

            createAndSaveXmlDoc(final, finalPath);

            try
            {
                xct.Transform(finalPath, output);
                MessageBox.Show("Трансформовано!", "", MessageBoxButtons.OK);
            }
            catch
            {
            }
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshModels()
        {
            comboBoxModel.Items.Clear();
            if (comboBoxBrand.SelectedItem == null)
            {
                return;
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement xRoot = doc.DocumentElement;
            XmlNodeList childNodes = xRoot.SelectNodes("Car");
            for (int i = 0; i < childNodes.Count; i++)
            {
                XmlNode n = childNodes.Item(i);
                if (n.SelectSingleNode("@Brand").Value == comboBoxBrand.SelectedItem.ToString())
                {
                    if (!comboBoxModel.Items.Contains(n.SelectSingleNode("@Model").Value))
                        comboBoxModel.Items.Add(n.SelectSingleNode("@Model").Value);
                }
            }
        }

        private static void createAndSaveXmlDoc(List<CarSale> final, string fpath)
        {
            var xmlDoc = new XmlDocument();
            XmlElement el;
            int childCounter;
            xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null));
            el = xmlDoc.CreateElement("CarSales");
            xmlDoc.AppendChild(el);
            for (childCounter = 1; childCounter <= final.Count(); childCounter++)
            {
                XmlElement childel;
                childel = xmlDoc.CreateElement("Car");

                childel.SetAttribute("Body", final[childCounter - 1].Body);
                childel.SetAttribute("Brand", final[childCounter - 1].Brand);
                childel.SetAttribute("Model", final[childCounter - 1].Model);
                childel.SetAttribute("Region", final[childCounter - 1].Region);
                childel.SetAttribute("Year", final[childCounter - 1].Year);
                childel.SetAttribute("Price", final[childCounter - 1].Price);

                el.AppendChild(childel);
            }

            xmlDoc.Save(fpath);
        }
    }
}
