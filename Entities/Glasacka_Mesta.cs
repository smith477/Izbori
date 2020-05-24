﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entities
{
    public class Glasacka_Mesta
    {
        public virtual int Id { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual int Broj_biraca { get; set; }
        public virtual int Broj_mesta { get; set; }
        public virtual IList<Aktivista_Stranke> Aktivisti { get; set; }
       // public virtual IList<Rezultati> Rezultati { get; set; }
        public virtual IList<Primedbe> Primedbe { get; set; }

        public Glasacka_Mesta()
        {
            Aktivisti = new List<Aktivista_Stranke>();
            //Rezultati = new List<Rezultati>();
            Primedbe = new List<Primedbe>();
        }

    }
}
