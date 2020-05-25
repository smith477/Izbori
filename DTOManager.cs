using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using Izbori.Entities;

namespace Izbori
{
    public class DTOManager
    {

    
        public static List<KoordinatorPregled> GetOdInfos(int koordinatorId)
        {
            List<KoordinatorPregled> odInfos = new List<KoordinatorPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Koordinator_Opstine> koordinator = from k in s.Query<Koordinator_Opstine>()
                                                   where k.Id == koordinatorId
                                                   select k;

                foreach (Koordinator_Opstine k in koordinator)
                {
                        odInfos.Add(new KoordinatorPregled(k.Id, k.Licno_ime, k.Prezime, k.PratiGlasackoMesto.Id, k.PratiGlasackoMesto.Naziv, k.PratiGlasackoMesto.Broj_biraca));

                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odInfos;
        }

        public static KoordinatorBasic GetKoordinatorBasic(int odId)
        {
            KoordinatorBasic ob = new KoordinatorBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Koordinator_Opstine o = s.Load<Koordinator_Opstine>(odId);
                ob = new KoordinatorBasic(o.Id, o.PratiGlasackoMesto.Naziv, o.PratiGlasackoMesto.Broj_biraca);

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return ob;
        }

        public static KoordinatorBasic UpdateKoordinatorBasic(KoordinatorBasic ob)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Koordinator_Opstine o = s.Load<Koordinator_Opstine>(ob.KoordinatorId);
                o.PratiGlasackoMesto.Naziv = ob.Glasacko_Mesto_Naziv;
                o.PratiGlasackoMesto.Broj_biraca = ob.Glasacko_Mesto_Broj;

                s.Update(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return ob;
        }
    }
}
