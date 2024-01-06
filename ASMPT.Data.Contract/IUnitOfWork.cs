using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.Data.Contract
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
