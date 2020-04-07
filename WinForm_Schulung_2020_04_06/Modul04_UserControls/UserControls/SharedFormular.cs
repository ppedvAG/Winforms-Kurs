using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul04_UserControls.UserControls
{
    public partial class SharedFormular : UserControl
    {
        public SharedFormular()
        {
            InitializeComponent();
        }

        private void SharedFormular_Load(object sender, EventArgs e)
        {
            //throw new Exception(); -> Expetion habe ich proviziert um zu zeigen, dass ein UserControl im DesignModus (Visual Studio Designer), nicht mehr aufgelöst werde kann.
            List<string> stringListe = new List<string>();
            stringListe.Add("abc");
            stringListe.Add("def");
            stringListe.Add("ghi");
            stringListe.Add("jkl");

            foreach (string currentString in stringListe)
            {
                listBox1.Items.Add(currentString);
            }
        }
    }
}
