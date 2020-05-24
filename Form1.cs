using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Izbori.Entities;

namespace Izbori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdUcitavanjeIzbora_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Aktivista_Stranke aktivista = session.Load<Aktivista_Stranke>(20);
                MessageBox.Show(aktivista.Licno_ime);

                session.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodavanjeAktiviste_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Aktivista_Stranke aktivista = new Aktivista_Stranke();

                //aktivista = session.Load<Aktivista_Stranke>(41); //Za azuriranje, na dole isti kod

                aktivista.Licno_ime = "Marko";
                aktivista.Ime_roditelja = "Miodrag";
                aktivista.Prezime = "Ilic";
                aktivista.Ulica = "Rudnicka";
                aktivista.Broj = "18b";
                aktivista.Datum_rodjenja = Convert.ToDateTime("21-JAN-1997");


                session.Save(aktivista);
                //session.SaveOrUpdate(aktivista);

                session.Flush();
                session.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdManyToOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Aktivista_Stranke aktivista = session.Load<Aktivista_Stranke>(20);
                Glasacka_Mesta mesto = session.Load<Glasacka_Mesta>(21);

                MessageBox.Show(aktivista.Licno_ime);
                MessageBox.Show(aktivista.PratiGlasackoMesto.Naziv);
                //Glasacka_Mesta mesto = aktivista.PratiGlasackoMesto;
                //MessageBox.Show(mesto.Naziv);

                //MessageBox.Show(mesto.Naziv);
                session.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodavanjeGlasackogMesta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Glasacka_Mesta glasacko_mesto = new Glasacka_Mesta();

                //aktivista = session.Load<Aktivista_Stranke>(41); //Za azuriranje, na dole isti kod

                glasacko_mesto.Naziv = "TRG KRALJA MILANA";
                glasacko_mesto.Broj_biraca = 55;
                glasacko_mesto.Broj_mesta = 100;


                session.Save(glasacko_mesto);
                //session.SaveOrUpdate(aktivista);

                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

         
                Glasacka_Mesta mesto = session.Load<Glasacka_Mesta>(20);

                MessageBox.Show(mesto.Naziv);
                foreach (Primedbe pr in mesto.Primedbe)
                {
                    MessageBox.Show(pr.Primedba);
                }
                //Glasacka_Mesta mesto = aktivista.PratiGlasackoMesto;
                //MessageBox.Show(mesto.Naziv);

                //MessageBox.Show(mesto.Naziv);
                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
