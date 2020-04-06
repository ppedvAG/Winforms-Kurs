using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace Modul01_HelloWinForms
{
    public partial class MainView : Form
    {
        // Das ist deine Datei zum Programmieren
        public MainView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Beim Laden eines Formulares wird diese Ereignis-Methode
        /// </summary>
        /// <param name="sender">Parameterbeschreibung</param>
        /// <param name="e"></param>
        private void MainView_Load(object sender, EventArgs e)
        {
            this.Text = "Willkommen beim WinForm - Kurs";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo Lieber Teilnehmer", "WinForm Kurs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyInputBox myInputBox = new MyInputBox();

            myInputBox.ShowDialog();
            string ausgelesenerText = myInputBox.TextValue;

            MessageBox.Show("Hallo " + ausgelesenerText);

        }
    }
}
