using Qadya.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qadya.Data.Repository.CaseRepo
{
    public class CaseRepo : ICaseRepo
    {
        public Case Add(Case entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Case> AddRange(IEnumerable<Case> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Case> GetAll(string[]? include = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Case>> GetAllAsync(string? search, string? status)
        {
            throw new NotImplementedException();
        }

        public Case GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Case> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<dynamic> GetStatisticsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
