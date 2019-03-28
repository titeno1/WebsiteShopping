using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebCoreShop.Application.ViewModels.Product;
using WebCoreShop.Application.ViewModels.System;
using WebCoreShop.Data.Entities;

namespace WebCoreShop.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<Function, FunctionViewModel>();
        }
    }
}
