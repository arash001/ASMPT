using ASMPT.Data.Contract;
using ASMTP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbModelContext _dbContext;

        public UnitOfWork(DbModelContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
