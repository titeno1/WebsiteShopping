using System;
using System.Collections.Generic;
using System.Text;
using WebCoreShop.Data.Entities;
using WebCoreShop.Data.IRepositories;

namespace WebCoreShop.Data.EF.Repositories
{
    public class TagRepository : EFRepository<Tag, string>, ITagRepository
    {
        public TagRepository(AppDbContext context) : base(context)
        {
        }
    }
}
