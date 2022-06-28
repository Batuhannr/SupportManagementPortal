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
    public class TicketFormsManager : ITicketFormsService
    {
        ITicketFormsDal _TicketFormsDal;

        public TicketFormsManager(ITicketFormsDal TicketFormsDal)
        {
            _TicketFormsDal = TicketFormsDal;
        }

        public void AboutAdd(TicketForms TicketForms)
        {
            _TicketFormsDal.Insert(TicketForms);
        }

        public void AboutDelete(TicketForms TicketForms)
        {
            _TicketFormsDal.Delete(TicketForms);
        }

        public void AboutUpdate(TicketForms TicketForms)
        {
            _TicketFormsDal.Update(TicketForms);
        }

        public List<TicketForms> GetAboutList()
        {
            return _TicketFormsDal.List();
        }

        public TicketForms GetByID(string id)
        {
            return _TicketFormsDal.Get(x => x.Id == id);
        }
    }
}