using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Persons : BaseClass
    {
        public int Phone { get; set; }
        public string Email { get; set; }
        public int PersonId { get; set; }
        public virtual Companies Companies { get; set; }

    }
}
