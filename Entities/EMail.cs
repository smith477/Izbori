using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbori.Entities
{
    public class Email
    {
        public virtual EmailId Id { get; set; }

        public Email()
        {
            Id = new EmailId();
        }
    }
}
