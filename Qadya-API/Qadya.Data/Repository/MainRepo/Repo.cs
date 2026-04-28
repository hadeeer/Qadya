using Microsoft.EntityFrameworkCore;
using Qadya.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qadya.Data.Repository.MainRepo
{
    public class Repo<T, TID> : IRepo<T, TID> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> dbSet;

        public Repo(ApplicationDbContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }
        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return entity;
        }

        public IEnumerable<T> AddRange(IEnumerable<T> entities)
        {
            var addRange= entities.ToList();
            _context.Set<T>().AddRange(addRange);
            return addRange;
        }
        public IEnumerable<T> GetAll(string[]? include = null)
        {
            throw new NotImplementedException();
        }

        public T GetById(TID id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(TID id)
        {
            throw new NotImplementedException();
        }
    }
}
