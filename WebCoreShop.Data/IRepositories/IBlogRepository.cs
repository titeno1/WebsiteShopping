using System;
using System.Collections.Generic;
using System.Text;
using WebCoreShop.Data.Entities;
using WebCoreShop.Infrastructure.Interfaces;

namespace WebCoreShop.Data.IRepositories
{
    public interface IBlogRepository : IRepository<Blog, int>
    {
    }
}
