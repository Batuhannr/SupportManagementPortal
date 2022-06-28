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
    public class CustomersManager : ICustomerService
    {
        ICustomersDal _customersDal;

        public CustomersManager(ICustomersDal customersdDal)
        {
            _customersDal = customersdDal;
        }

        public void AboutAdd(Customers customers)
        {
            _customersDal.Insert(customers);
        }

        public void AboutDelete(Customers customers)
        {
            _customersDal.Delete(customers);
        }

        public void AboutUpdate(Customers customers)
        {
            _customersDal.Update(customers);
        }

        public List<Customers> GetAboutList()
        {
            return _customersDal.List();
        }

        public Customers GetByID(int id)
        {
            return _customersDal.Get(x => x.Id == id);
        }
    }
}