using FluentNHibernate.Mapping;
using Izbori.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Mapping
{
    class Primedbe_Mapiranja : ClassMap<Primedbe>
    {
        public Primedbe_Mapiranja()
        {
            Table("PRIMEDBE");

            CompositeId(x => x.Id)
                .KeyReference(x => x.Glasacka_Mesta, "ID_GLASACKOG_MESTA")
                .KeyProperty(x => x.Primedbe, "PRIMEDBA");

        }
    }
}
