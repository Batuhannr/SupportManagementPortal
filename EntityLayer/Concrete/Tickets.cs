using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Tickets
    {
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Contents { get; set; }
        public virtual Persons Person { get; set; }
        public int PersonId { get; set; }
        public DateTime StartDate { get; set; }
        public int SituationId { get; set; }
        public virtual Situation Situation { get; set; }

        public int[] TagsId { get; set; }
        public ICollection<Tags> Tags { get; set; }
    }
}
