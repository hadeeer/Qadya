using Qadya.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qadya.Data
{
    public interface IUnitOfWork : IDisposable  //For Release unmanaged resources
    {
        IUserRepo Users { get; }


        int Save();
    }
}
