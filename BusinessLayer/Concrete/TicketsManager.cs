using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TicketsManager : ITicketsService
    {
        ITicketsDal _TicketsDal;

        public TicketsManager(ITicketsDal TicketsDal)
        {
            _TicketsDal = TicketsDal;
        }

        public void AboutAdd(Tickets Tickets)
        {
            _TicketsDal.Insert(Tickets);
        }

        public void AboutDelete(Tickets Tickets)
        {
            _TicketsDal.Delete(Tickets);
        }

        public void AboutUpdate(Tickets Tickets)
        {
            _TicketsDal.Update(Tickets);
        }

        public List<Tickets> GetAboutList()
        {
            return _TicketsDal.List();
        }

        public Tickets GetByID(int id)
        {
            return _TicketsDal.Get(x => x.Id == id);
        }
    }
}