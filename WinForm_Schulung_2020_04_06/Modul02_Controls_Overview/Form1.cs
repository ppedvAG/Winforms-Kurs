using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestdatenLibrary;

namespace Modul02_Controls_Overview
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region Konventieren mit Integer Werten
            
            //int myValue = Convert.ToInt32(txtValueSample.Text);
            //myValue = int.Parse(txtValueSample.Text);

            //if (int.TryParse(txtValueSample.Text, out myValue))
            //{
            //    // Wenn ich in diesen Code-Block reinkomme, dann ist der Wert valide
            //}
            //else
            //    MessageBox.Show("In der Eingabe ist keine gültige Zahl enthalten");
            #endregion

            #region Konventieren mit Komma Werten
            //Bei Kommzahlen wird mit Convert gerundet
            double myDoubleValue = Convert.ToDouble(txtValueSample.Text);
            //Bei Parse wird das Komma abgeschnitten
            myDoubleValue = double.Parse(txtValueSample.Text);

            if (double.TryParse(txtValueSample.Text, out myDoubleValue))
            {
                // Wenn ich in diesen Code-Block reinkomme, dann ist der Wert valide
            }

            // Zuweisung einer Zahl zu einem String, bzw hier txtResultBox.Text
            txtResultBox.Text = myDoubleValue.ToString();

            MessageBox.Show(this.ToString());
            label1.Text = myDoubleValue.ToString();

            #endregion
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("CheckBox wurde geändert auf : " + checkBox1.Checked.ToString() + " | " + Convert.ToInt32(checkBox1.Checked));
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                MessageBox.Show("RadioButton4 ist selektiert");
            }

            if (radioButton5.Checked == true)
            {
                MessageBox.Show("RadioButton5 ist selektiert");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (string item in checkedListBox1.CheckedItems)
            {
                MessageBox.Show(item + " wurde selektiert");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonListe testdatenListe = new PersonListe();
            listSample.DisplayMember = "Vorname";
            listSample.DataSource = testdatenListe.PersonenListe;
            

            comboBoxSample.DataSource = testdatenListe.PersonenListe;
            comboBoxSample.DisplayMember = "Vorname";
            //Vorauswahl auf das oberste Element der ComboBox Liste
            comboBoxSample.SelectedIndex = 0;

            PersonListe testdatenListe1 = new PersonListe();
            listSample2.DisplayMember = "KompletterName";
            listSample2.DataSource = testdatenListe1.PersonenListe;
            
            PersonListe testdatenListe2 = new PersonListe();
            comboBoxSample2.DataSource = testdatenListe2.PersonenListe;
            comboBoxSample2.DisplayMember = "Vorname";
            //Vorauswahl auf das oberste Element der ComboBox Liste
            comboBoxSample2.SelectedIndex = 0;

            //Direkte Manipulation in der Liste (wenn DataSource nicht verwendet wird)!
            listBox5.Items.Add("weiterer Listeneintrag");
            listBox5.Items.RemoveAt(0);

            


        }

        private void listSample2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("SelectedIndexChanged - Liste 2 wurde geändert");
        }

        private void listSample2_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("SelectedValueChanged - Liste 2 wurde geändert");
        }

        private void listSample_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSample.SelectedItem != null)
            {
                Person selectedPerson = (Person)listSample.SelectedItem;



                MessageBox.Show(selectedPerson.Id.ToString() + " | " + selectedPerson.Vorname + " " + selectedPerson.Nachname);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PopulateTreeView();
        }

        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"../..");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs,
            TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            #region Link - URL Aufruf auf Codeprojekt 
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://www.codeproject.com/Articles/23115/Working-with-TreeView-Controls-2";
            linkLabel1.Links.Add(link);
            #endregion

            #region 
            //Autofilter - Vorschlagsliste wird aufbereitet.
            AutoCompleteStringCollection colValues = new AutoCompleteStringCollection();
            colValues.AddRange(new string[] { "Berlin", "Hamburg", "Bremen", "Stuttgart", "Saarbrücken", "Frankfurt a.M." });

            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
            // Liste anhängen ...
            textBox1.AutoCompleteCustomSource = colValues;
            #endregion
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.codeproject.com/Articles/23115/Working-with-TreeView-Controls-2");
        }
    }
}
