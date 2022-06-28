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
    public class GroupManager : IGroupService
    {
        IGroupDal _GroupDal;

        public GroupManager(IGroupDal groupDal)
        {
            _GroupDal = groupDal;
        }

        public void AboutAdd(Group Group)
        {
            _GroupDal.Insert(Group);
        }

        public void AboutDelete(Group Group)
        {
            _GroupDal.Delete(Group);
        }

        public void AboutUpdate(Group Group)
        {
            _GroupDal.Update(Group);
        }

        public List<Group> GetAboutList()
        {
            return _GroupDal.List();
        }

        public Group GetByID(int id)
        {
            return _GroupDal.Get(x => x.Id == id);
        }
    }
}