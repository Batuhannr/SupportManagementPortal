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
    public class AccountLevelManager : IAccountLevelService
    {
        IAccountLevelDal _accountLevelDal;

        public AccountLevelManager(IAccountLevelDal accountLevelDal)
        {
            _accountLevelDal = accountLevelDal;
        }

        public void AboutAdd(AccountLevel accountLevel)
        {
            _accountLevelDal.Insert(accountLevel);
        }

        public void AboutDelete(AccountLevel accountLevel)
        {
            _accountLevelDal.Delete(accountLevel);
        }

        public void AboutUpdate(AccountLevel accountLevel)
        {
            _accountLevelDal.Update(accountLevel);
        }

        public List<AccountLevel> GetAboutList()
        {
            return _accountLevelDal.List();
        }

        public AccountLevel GetByID(int id)
        {
            return _accountLevelDal.Get(x => x.Id == id);
        }
    }
}