using System;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ITicketsDal : IRepository<Tickets>
    {
    }
}
