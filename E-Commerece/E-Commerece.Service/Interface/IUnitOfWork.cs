using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerece.DomainModel.Model;
namespace E_Commerece.Service.Interface
{
    public interface IUnitOfWork: IDisposable
    {        
        //ICategoryRepository Category { get; }

        ICategoryRepository Category { get; }
        IProductRepository Product { get; }

        int Save();
    }
}
