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

                MessageBox.Show(aktivista.Licno_ime);
                MessageBox.Show(aktivista.PratiGlasackoMesto.Naziv);

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

                glasacko_mesto.Naziv = "TRG";
                glasacko_mesto.Broj_biraca = 55;
                glasacko_mesto.Broj_mesta = 100;

                Aktivista_Stranke aktivista = new Aktivista_Stranke()
                {
                    Licno_ime = "Nikola",
                    Ime_roditelja = "Dragan",
                    Prezime = "Kovacevic",
                    Datum_rodjenja = Convert.ToDateTime("08-JAN-1998"),
                    Ulica = "BK",
                    Broj = "23"

                };

                glasacko_mesto.Aktivisti.Add(aktivista);
                aktivista.PratiGlasackoMesto = glasacko_mesto;


                session.Save(glasacko_mesto);
                session.Flush();

                session.Save(aktivista);
                session.Flush();

                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdOneToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Glasacka_Mesta gm = session.Load<Glasacka_Mesta>(40);

                foreach(Aktivista_Stranke a in gm.Aktivisti)
                {
                    MessageBox.Show(a.Licno_ime + " " + a.Prezime);
                }

                session.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdPrimedbe_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Glasacka_Mesta gm = session.Load<Glasacka_Mesta>(20);
                foreach(Primedbe p in gm.Primedbe)
                {
                    MessageBox.Show(p.Id.Primedbe);
                }
                //string pr = "Jao mene";

                //Primedbe primedba = new Primedbe();
                //primedba.Id.Glasacka_Mesta = gm;
                //primedba.Id.Primedbe = pr;

                //session.Save(primedba);
                //session.Flush();
                //session.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdEmailAktiviste_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Aktivista_Stranke aktivista = session.Load<Aktivista_Stranke>(20);
                foreach (Email email in aktivista.Email)
                {
                    MessageBox.Show(email.Id.Email);
                }

                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdTelefonAktiviste_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Aktivista_Stranke aktivista = session.Load<Aktivista_Stranke>(20);
                foreach (Telefon telefon in aktivista.Telefon)
                {
                    MessageBox.Show(telefon.Id.Telefon);
                }
                
                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdGMRezultati_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Glasacka_Mesta gm = session.Load<Glasacka_Mesta>(20);
                foreach (Rezultati rezultat in gm.Rezultati)
                {
                    MessageBox.Show("Broj biraca: " + rezultat.Broj_Biraca + " Procenat glasanja: " + rezultat.Procenat_Glasanja + " Krug izbora: "
                        + rezultat.Krug_Izbora + " Naziv glasackog mesta: " + rezultat.Id.Glasacka_Mesta.Naziv);
                }

                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdKoordinatorOpstine_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                IList<Aktivista_Stranke> aktivista = session.QueryOver<Aktivista_Stranke>()
                                                            .Where(a => a.Id == 20)
                                                            .List<Aktivista_Stranke>();

                Koordinator_Opstine k = (Koordinator_Opstine)aktivista[0];
                MessageBox.Show(k.Adresa_Kancelarije);

                session.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdKreirajKoordinatora_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Koordinator_Opstine koordinator = new Koordinator_Opstine();

                koordinator.Licno_ime = "Marko";
                koordinator.Ime_roditelja = "Miodrag";
                koordinator.Prezime = "Marinkovic";
                koordinator.Datum_rodjenja = Convert.ToDateTime("22-SEP-1998");
                koordinator.Ulica = "Nova Ulica";
                koordinator.Broj = "7a";

                koordinator.Adresa_Kancelarije = "Nova Adresa";
                koordinator.Ime_Opstine = "Medijana";

                session.Save(koordinator);
                session.Flush();
                session.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdAkcija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                IList<Izborne_Aktivnosti> aktivnost = session.QueryOver<Izborne_Aktivnosti>()
                                                            .Where(a => a.Id == 20)
                                                            .List<Izborne_Aktivnosti>();

                Deljenje_Letki ak = (Deljenje_Letki)aktivnost[0];
                MessageBox.Show(ak.Koordinator.Licno_ime);

                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
