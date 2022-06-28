using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Representative : BaseClass
    {

        public int Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int GroupId { get; set; }
        public int TitleId { get; set; }
        public int CompaniesId { get; set; }
        public virtual Title Titles { get; set; }
        public virtual Group Groups { get; set; }
        public virtual Companies Companies { get; set; }

    }

    
}
