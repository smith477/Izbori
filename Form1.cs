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
using NHibernate.Criterion;

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

                koordinator.Licno_ime = "Ana";
                koordinator.Ime_roditelja = "Miodrag";
                koordinator.Prezime = "Anic";
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

        private void cmdDodajLetke_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Deljenje_Letki letka = new Deljenje_Letki();
                Koordinator_Opstine koordinator = new Koordinator_Opstine()
                {
                    Licno_ime = "Antonio",
                    Ime_roditelja = "Migel",
                    Prezime = "Banderas",
                    Datum_rodjenja = Convert.ToDateTime("23-APR-1972"),
                    Adresa_Kancelarije = "Barcelona",
                    Ime_Opstine = "Barca",
                    Ulica = "La Casa",
                    Broj = "66"
                };
                session.Save(koordinator);
                session.Flush();

                letka.Grad = "Bujanovac";
                letka.Koordinator = koordinator;

                session.Save(letka);
                session.Flush();


                
                Lokacije lokacija = new Lokacije();
                lokacija.Id.Deljenje_Letki = letka;
                lokacija.Id.Lokacija = "Center";
                session.Save(lokacija);
                session.Flush();
                letka.Lokacije.Add(lokacija);

                session.Save(letka);
                session.Flush();

                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdGetSusreti_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Susreti_Kandidata_Sa_Gradjanima susreti = session.Get<Susreti_Kandidata_Sa_Gradjanima>(22);
                if(susreti != null)
                {
                    MessageBox.Show("Grad: " + susreti.Grad + "\nVreme: " + susreti.Vreme.ToString("dd-MM-yyyy") + "\nZaduzen koordinator: "
                    + susreti.Koordinator.Licno_ime + " " + susreti.Koordinator.Prezime);
                }
                else
                {
                    MessageBox.Show("Ne postoji odeljenje sa zadatim identifikatorom");
                }
                
                session.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajMitingNaZatvorenom_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                //IList<Gost> gost = session.QueryOver<Gost>()
                //                              .Where(g => g.Id.Id == 20)
                //                              .List<Gost>();

                //MessageBox.Show(gost[0].Licno_Ime);

                Politicki_Miting miting = session.Get<Politicki_Miting>(25);
                Politicki_Miting_Na_Zatvorenom zatvorenom = (Politicki_Miting_Na_Zatvorenom)miting;
                MessageBox.Show(zatvorenom.Gosti[0].Licno_Ime);
                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdManyToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Aktivista_Stranke aktivista = session.Load<Aktivista_Stranke>(20);

                foreach(Akcije a in aktivista.Akcije)
                {
                    MessageBox.Show(a.Id.ToString());
                }

                Akcije akcija = session.Load<Akcije>(20);

                foreach(Aktivista_Stranke a in akcija.Aktivisti)
                {
                    MessageBox.Show(a.Licno_ime);
                }

                session.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Aktivista_Stranke aktivista = session.Load<Aktivista_Stranke>(41);

                aktivista.Ulica = "Branka Krsmanovica 11";


                session.Update(aktivista);

                session.Flush();
                session.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Aktivista_Stranke aktivista = session.Load<Aktivista_Stranke>(85);

                //brise se objekat iz baze ali ne i instanca objekta u memroiji
                session.Delete(aktivista);
                //s.Delete("from Odeljenje");

                session.Flush();
                session.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Aktivista_Stranke aktivista = session.Load<Aktivista_Stranke>(21);

                ITransaction t = session.BeginTransaction();

                session.Delete(aktivista);

                //t.Commit();
                t.Rollback();

                session.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdLINQ_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                IList<Koordinator_Opstine> koordinatori = (from o in session.Query<Koordinator_Opstine>()
                                              where (o.Adresa_Kancelarije == "Nova Adresa")
                                              select o).ToList<Koordinator_Opstine>();

                foreach (Koordinator_Opstine k in koordinatori)
                {
                    MessageBox.Show(k.Licno_ime + " " + k.Prezime);
                }


                session.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdLINQ1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Lokacije> lokacije = from l in session.Query<Lokacije>()
                                                  where (l.Id.Lokacija == "Centar" || l.Id.Lokacija == "Bulevar")
                                                  orderby l.Id.Lokacija
                                                  select l;

                foreach (Lokacije l in lokacije)
                {
                    MessageBox.Show(l.Id.Deljenje_Letki.Grad);
                }

                session.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdLINQ2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Aktivista_Stranke> aktivisti = session.Query<Aktivista_Stranke>()
                                                    .Where(l => (l.Licno_ime == "Marko" && l.PratiGlasackoMesto != null))
                                                    .OrderBy(l => l.Prezime).ThenBy(l => l.Ime_roditelja)
                                                    .Select(l => l);
                                                    


                foreach (Aktivista_Stranke a in aktivisti)
                {
                    MessageBox.Show(a.PratiGlasackoMesto.Naziv);
                }

                session.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdPregledAktivista_Click(object sender, EventArgs e)
        {
            Koordinator_Opstine_Informacije odInfoForm = new Koordinator_Opstine_Informacije(100);

            odInfoForm.Show();
        }

        private void btnScalar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                IQuery q = session.CreateQuery("select sum(o.Broj_Biraca * (o.Procenat_Glasanja/100)) from Rezultati o;");

                Int64 brojGlasova = q.UniqueResult<Int64>();

                MessageBox.Show(brojGlasova.ToString());

                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPaging_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Aktivista_Stranke");
                q.SetFirstResult(3);
                q.SetMaxResults(3);

                IList<Aktivista_Stranke> odeljenja = q.List<Aktivista_Stranke>();

                foreach (Aktivista_Stranke o in odeljenja)
                {
                    MessageBox.Show(o.Licno_ime.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ICriteria c = s.CreateCriteria<Susreti_Kandidata_Sa_Gradjanima>();

                c.Add(Expression.Ge("Lokacija", "Nis"));
                c.Add(Expression.Eq("Vreme", new DateTime(2020, 11, 22)));

                IList<Susreti_Kandidata_Sa_Gradjanima> odeljenja = c.List<Susreti_Kandidata_Sa_Gradjanima>();

                foreach (Susreti_Kandidata_Sa_Gradjanima o in odeljenja)
                {
                    MessageBox.Show(o.Lokacija);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Aktivista_Stranke> odeljenja = s.QueryOver<Aktivista_Stranke>()
                                                .Where(x => x.Ulica == "Romanijska")
                                                .Where(x => x.Ime_roditelja == "Miodrag")
                                                .List<Aktivista_Stranke>();

                foreach (Aktivista_Stranke o in odeljenja)
                {
                    MessageBox.Show(o.Id.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ISQLQuery q = s.CreateSQLQuery("SELECT O.* FROM GOST O");
                q.AddEntity(typeof(Gost));


                IList<Gost> gost = q.List<Gost>();

                foreach (Gost o in gost)
                {
                    MessageBox.Show(o.Licno_Ime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Koordinator_Opstine k = session.Load<Koordinator_Opstine>(20);

                MessageBox.Show("Trenutna vrednost: " + k.Adresa_Kancelarije);
                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                ISession session = DataLayer.GetSession();

                Koordinator_Opstine k = session.Load<Koordinator_Opstine>(20);
                //originalna sesija se zatvara i raskida se veza izmedju objekta i sesije

                //objekat se modifikuje potpuno nezavisno od sesije
                k.Adresa_Kancelarije = "Azurirana Adresa 40";

                //otvara se nova sesija

                //poziva se Update i objekat se povezuje sa novom sesijom
                session.Update(k);

                session.Flush();

                session.Refresh(k);
                MessageBox.Show("Azurirana vrednost: " + k.Adresa_Kancelarije);
                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmdKreiranjeUpita_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Aktivista_Stranke");

                IList<Aktivista_Stranke> rezultati = q.List<Aktivista_Stranke>();
                foreach (Aktivista_Stranke a in rezultati)
                {
                    MessageBox.Show(a.Prezime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdKreiranjeUpita1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Aktivista_Stranke as o where o.Licno_ime = 'Ana'");

                IList<Aktivista_Stranke> rezultati = q.List<Aktivista_Stranke>();
                foreach (Aktivista_Stranke a in rezultati)
                {
                    MessageBox.Show(a.Prezime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdKreiranjeUpitaSaParametrima_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Paramterizovani upit
                IQuery q = s.CreateQuery("from Koordinator_Opstine as o where o.Adresa_Kancelarije = ? and o.Ime_Opstine >= ?");
                q.SetParameter(0, "BK 22");
                q.SetParameter(1, "Medijana");

                IList<Koordinator_Opstine> rezultat = q.List<Koordinator_Opstine>();

                foreach (Koordinator_Opstine ko in rezultat)
                {
                    MessageBox.Show(ko.Licno_ime + "    " + ko.Prezime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdKreiranjeUpitaSaImenovanimParametrima_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Paramterizovani upit
                IQuery q = s.CreateQuery("select o.Rezultati from Glasacka_Mesta as o "
                                        + " where o.Naziv = :naziv and o.Broj_biraca >= :bb");
                q.SetString("naziv", "Sveti Sava");
                q.SetInt32("bb", 500);

                IList<Rezultati> rezultati = q.List<Rezultati>();

                foreach (Rezultati r in rezultati)
                {
                    MessageBox.Show(r.Procenat_Glasanja.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdKreiranjeUpitaSaImenovanimParametrima1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select o.PratiGlasackoMesto from Aktivista_Stranke as o "
                                        + " where o.Licno_ime = :lime and o.Prezime = :pime"
                                        + " and o.PratiGlasackoMesto.Broj_biraca >= :bb");
                q.SetString("lime", "Marko");
                q.SetString("pime", "Ilic");
                q.SetInt32("bb", 55);

                IList<Glasacka_Mesta> rezultati = q.List<Glasacka_Mesta>();

                foreach (Glasacka_Mesta gm in rezultati)
                {
                    MessageBox.Show(gm.Naziv);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdKoriscenjeEnumerable_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Aktivista_Stranke");

                IEnumerable<Aktivista_Stranke> rezultati = q.Enumerable<Aktivista_Stranke>();

                foreach (Aktivista_Stranke a in rezultati)
                {
                    if (a.Licno_ime == "Antonio")
                        MessageBox.Show(a.Licno_ime + "    " + a.Prezime);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
    }

