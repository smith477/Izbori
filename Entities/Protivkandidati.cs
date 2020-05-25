using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entities
{
    public class Protivkandidati
    {
        public virtual ProtivkandidatiId Id { get; set; }

        public Protivkandidati()
        {
            Id = new ProtivkandidatiId();
        }
    }
}
