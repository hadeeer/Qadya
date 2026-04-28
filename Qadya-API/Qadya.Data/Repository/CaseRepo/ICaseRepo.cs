using Qadya.Data.Models;
using Qadya.Data.Repository.MainRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qadya.Data
{
    public interface ICaseRepo: IRepo<Case,int>
    {
        Task <IEnumerable<Case>> GetAllAsync(string? search, string? status);
    
        Task<dynamic> GetStatisticsAsync();
     
    }
}
