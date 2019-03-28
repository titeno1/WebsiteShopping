using System;
using System.Collections.Generic;
using System.Text;
using WebCoreShop.Data.Entities;
using WebCoreShop.Data.IRepositories;

namespace WebCoreShop.Data.EF.Repositories
{
    public class FunctionRepository : EFRepository<Function, string>, IFunctionRepository
    {
        public FunctionRepository(AppDbContext context) : base(context)
        {

        }
    }
}
