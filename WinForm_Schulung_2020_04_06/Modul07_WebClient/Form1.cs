using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul07_WebClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Bitte ein Suchbegriff eingeben");
                return;
            }

            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;

            string url = "https://www.googleapis.com/books/v1/volumes?q=" + textBox1.Text;
            string json  = wc.DownloadString(url);

            //jsonTb.Text = txt;

            Rootobject br = JsonConvert.DeserializeObject<Rootobject>(json);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = br.items.Select(x => x.volumeInfo).ToList(); 
        }
    }
}
