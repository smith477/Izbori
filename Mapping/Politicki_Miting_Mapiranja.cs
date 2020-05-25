using FluentNHibernate.Mapping;
using Izbori.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Mapping
{
    class Politicki_Miting_Mapiranja : SubclassMap<Politicki_Miting>
    {
        public Politicki_Miting_Mapiranja()
        {
            Table("POLITICKI_MITING");

            KeyColumn("ID_IZBORNE_AKTIVNOSTI");

            Map(x => x.Lokacija, "LOKACIJA");
            Map(x => x.Mesto, "MESTO");

            HasMany(x => x.Gosti).KeyColumn("ID_IZBORNE_AKTIVNOSTI").LazyLoad().Cascade.All().Inverse();
        }
    }

}
