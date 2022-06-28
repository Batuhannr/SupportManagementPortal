using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Companies : BaseClass
    {
        public string About { get; set; }
        public string Notes { get; set; } 
        public DateTime RenewalDate { get; set; }
        public virtual AccountLevel AccountLevels { get; set; }
        public int SectorId { get; set; }
        public virtual Sector Sectors { get; set; }
        public int RepresetativesId { get; set; }
        public ICollection<Representative> Representatives { get; set; }
    }
}
