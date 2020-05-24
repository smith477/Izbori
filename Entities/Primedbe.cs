using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entities
{
    public class Primedbe
    {
        public virtual PrimedbeId Id { get; set; }

        public Primedbe()
        {
            Id = new PrimedbeId();
        }
    }
}
