using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul03_ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            int value = 0;
            double dValue = 0;
            if (int.TryParse(text, out value) || double.TryParse(text, out dValue))
            {
                errorProvider1.Clear();
            }
            else
                errorProvider1.SetError(textBox1, "Bitte geben Sie eine Zahl ein");



            if (text.Length > 0)
            {
                errorProvider1.Clear();
            }
            else
                errorProvider1.SetError(button1, "Textfeld muss ausgefüllt sein, bevor man Button klickt");

        }
    }
}
