using E_Commerece.Context;
using E_Commerece.DomainModel.Model;
using E_Commerece.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerece.Service.Implementation
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ECommDbContext context) : base(context)
        {
        }
    }
}
