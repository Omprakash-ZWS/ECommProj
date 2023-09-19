using E_Commerece.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerece.Service.Implementation
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public ICategoryRepository Category => throw new NotImplementedException();

        public IProductRepository Product => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }
    }
}
