using System;
using System.Collections.Generic;
using System.Text;
using WebCoreShop.Application.ViewModels.Common;

namespace WebCoreShop.Application.Interfaces
{
    public interface ICommonService
    {
        FooterViewModel GetFooter();
        List<SlideViewModel> GetSlides(string groupAlias);
        SystemConfigViewModel GetSystemConfig(string code);
    }
}
