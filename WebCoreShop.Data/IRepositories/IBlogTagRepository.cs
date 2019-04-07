using System;
using System.Collections.Generic;
using System.Text;
using WebCoreShop.Data.Entities;
using WebCoreShop.Infrastructure.Interfaces;

namespace WebCoreShop.Data.IRepositories
{
    public interface IBlogTagRepository : IRepository<BlogTag, int>
    {
    }
}
