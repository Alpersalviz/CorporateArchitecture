using PalaFramework.Core.Entities;
using System; 
using System.Linq; 
namespace PalaFramework.Core.DataAccess
{
    public interface IQueryableRepository<T> where T: class , IEntity , new()
    {
        IQueryable<T> Table { get; }

    }
}
