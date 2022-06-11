using SiteManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Dal.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : EntityBase;

        bool BeginTransaction(); // start transaction
        bool RollBackTransaction(); //undo operation in case of error

        int SaveChanges();
    }
}
