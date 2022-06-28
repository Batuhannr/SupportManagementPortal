using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Group : BaseClass
    {
        public ICollection<Representative> Representatives{ get; set; }
    }
}
