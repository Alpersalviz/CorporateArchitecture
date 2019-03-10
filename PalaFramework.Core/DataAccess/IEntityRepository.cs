 using PalaFramework.Core.Entities;
using System;
using System.Collections.Generic; 
using System.Linq.Expressions; 

namespace PalaFramework.Core.DataAccess
{
    //tüm repolarda Generic çalışması içi <T> verdim
    public interface IEntityRepository<T> where T: IEntity , new()
    {
        List<T> GetList(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter=null);

        T Add(T entity);
        T Update(T entity);
        //Neden nesne gönderdim bazılar string bazıları integer primary key type değişebilir
        void Delete(T entity);

    }
}
