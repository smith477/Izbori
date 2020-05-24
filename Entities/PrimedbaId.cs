using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entities
{
    public class PrimedbaId
    {
        public virtual string Primedba { get; set; }
        public virtual Glasacka_Mesta Glasacko_Mesto { get; set; }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(PrimedbaId))
                return false;

            PrimedbaId recievedObject = (PrimedbaId)obj;

            if ((Primedba == recievedObject.Primedba) &&
                (Glasacko_Mesto.Id == recievedObject.Glasacko_Mesto.Id))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
