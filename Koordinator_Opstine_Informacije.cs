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
    public partial class Koordinator_Opstine_Informacije : Form
    {
        public int KoordinatorId { get; set; }
        public Koordinator_Opstine_Informacije()
        {
            InitializeComponent();
        }

        public Koordinator_Opstine_Informacije(int kId)
        {
            this.KoordinatorId = kId;
            InitializeComponent();
        }

        private void Koordinator_Opstine_Informacije_Load(object sender, EventArgs e)
        {
            this.PopulateInfos();
        }

        private void PopulateInfos()
        {
            listView1.Items.Clear();
            List<KoordinatorPregled> odInfos = DTOManager.GetOdInfos(this.KoordinatorId);
            foreach (KoordinatorPregled op in odInfos)
            {
                ListViewItem item = new ListViewItem(new string[] { op.KoordinatorId.ToString(), op.Koordinator_Ime, op.Koordinator_Prezime, op.Glasacko_Mesto_Id.ToString(), op.Glasacko_Mesto_Naziv, op.Glasacko_Mesto_Broj.ToString() });

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite koordinatora");
                return;
            }

            int odId = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            KoordinatorBasic ob = DTOManager.GetKoordinatorBasic(odId);

            Izmena_Glasackog_Mesta edbForm = new Izmena_Glasackog_Mesta(ob);
            if (edbForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //MessageBox.Show("snimanje podataka");
                DTOManager.UpdateKoordinatorBasic(edbForm.kBasic);
                PopulateInfos();
            }
        }
    }
}
