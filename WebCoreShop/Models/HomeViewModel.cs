using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreShop.Application.ViewModels.Blog;
using WebCoreShop.Application.ViewModels.Common;
using WebCoreShop.Application.ViewModels.Product;

namespace WebCoreShop.Models
{
    public class HomeViewModel
    {
        public List<BlogViewModel> LastestBlogs { get; set; }
        public List<SlideViewModel> HomeSlides { get; set; }
        public List<ProductViewModel> HotProducts { get; set; }
        public List<ProductViewModel> TopSellProducts { get; set; }

        public List<ProductCategoryViewModel> HomeCategories { set; get; }

        public string Title { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
}
