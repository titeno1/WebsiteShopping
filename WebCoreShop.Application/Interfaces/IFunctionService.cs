using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebCoreShop.Application.ViewModels.System;

namespace WebCoreShop.Application.Interfaces
{
    public interface IFunctionService : IDisposable
    {
        Task<List<FunctionViewModel>> GetAll();

        List<FunctionViewModel> GetAllByPermission(Guid userId);
    }
}