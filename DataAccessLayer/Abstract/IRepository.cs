using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository <T>
    {
        //listeleme
        List<T> List();
        //ID yi bulma
        T Get(Expression<Func<T, bool>> filter);

        //ekleme
        void Insert(T p);

        //güncelleme
        void Update(T p);

        //silme
        void Delete(T p);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
