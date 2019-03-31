using System;
using System.Collections.Generic;
using System.Text;
using WebCoreShop.Application.ViewModels.Product;
using WebCoreShop.Utilities.Dtos;

namespace WebCoreShop.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel>GetAll();
        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);

        ProductViewModel Add(ProductViewModel product);

        void Update(ProductViewModel product);

        void Delete(int id);

        ProductViewModel GetById(int id);

        void ImportExcel(string filePath, int categoryId);

        void Save();
    }
}
