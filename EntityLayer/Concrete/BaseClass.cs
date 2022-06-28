using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BaseClass
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime UpdateDate { get { return _UpdateDate; } set { _UpdateDate = DateTime.Now; } }
        public bool Deleted { get; set; }
        DateTime _UpdateDate { get; set; }
    }
}
