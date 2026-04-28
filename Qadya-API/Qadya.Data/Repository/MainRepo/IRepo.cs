using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Qadya.Data.Repository.MainRepo
{
    public interface IRepo<T, in TID> where T : class
    {
        IEnumerable<T> GetAll(string[]? include = null);
        T GetById(TID id);

        Task<T> GetByIdAsync(TID id);

        IEnumerable<T> AddRange(IEnumerable<T> entities);


       // Task<IEnumerable<T>> GetAllAsync()
      //  IEnumerable<T> GetAllByDefault(Expression<Func<T, bool>>? filter = null, string? includeProperites = null);

        T Add(T entity);
        //void Update(T entity);
        //void Delete(TID id);
    }
}
