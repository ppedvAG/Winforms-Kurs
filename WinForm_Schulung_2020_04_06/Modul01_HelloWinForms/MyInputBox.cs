using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul01_HelloWinForms
{
    public partial class MyInputBox : Form
    {
        public string TextValue { get; set; }
        public MyInputBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextValue = textBox1.Text;
            this.Close();
        }
    }
}
