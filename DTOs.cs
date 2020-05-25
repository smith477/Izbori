using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori
{
    public class KoordinatorPregled
    {
        public int KoordinatorId { get; set; }
        public string Koordinator_Ime { get; set; }
        public string Koordinator_Prezime { get; set; }
        public int Glasacko_Mesto_Id { get; set; }
        public string Glasacko_Mesto_Naziv { get; set; }
        public int Glasacko_Mesto_Broj { get; set; }

        public KoordinatorPregled(int kId, string ime, string prezime, int ikId, string naziv, int broj)
        {
            this.KoordinatorId = kId;
            this.Koordinator_Ime = ime;
            this.Koordinator_Prezime = prezime;
            this.Glasacko_Mesto_Id = ikId;
            this.Glasacko_Mesto_Naziv = naziv;
            this.Glasacko_Mesto_Broj = broj;
        }


    }

    public class KoordinatorBasic
    {
        public int KoordinatorId { get; set; }
        public string Glasacko_Mesto_Naziv { get; set; }
        public virtual int Glasacko_Mesto_Broj { get; set; }

        public KoordinatorBasic(int odId, string naziv, int broj)
        {
            this.KoordinatorId = odId;
            this.Glasacko_Mesto_Naziv = naziv;
            this.Glasacko_Mesto_Broj = broj;
            
        }

        public KoordinatorBasic()
        {
        }
    }


}
