using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Izbori
{
    public partial class Izmena_Glasackog_Mesta : Form
    {
        public KoordinatorBasic kBasic;
        public Izmena_Glasackog_Mesta()
        {
            InitializeComponent();
        }

        public Izmena_Glasackog_Mesta(KoordinatorBasic kb)
        {
            this.kBasic = kb;
            InitializeComponent();
            PopulateData();
        }

        private void PopulateData()
        {
            textBox_naz.Text = kBasic.Glasacko_Mesto_Naziv;
            textBox_brm.Text = kBasic.Glasacko_Mesto_Broj.ToString();
            
        }

        private void Izmena_Glasackog_Mesta_Load(object sender, EventArgs e)
        {

        }

        private void textBox_naz_TextChanged(object sender, EventArgs e)
        {
            kBasic.Glasacko_Mesto_Naziv = textBox_naz.Text;
        }

        private void textBox_brm_TextChanged(object sender, EventArgs e)
        {
            kBasic.Glasacko_Mesto_Broj = Convert.ToInt32(textBox_brm.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
