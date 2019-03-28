using System;
using System.Collections.Generic;
using System.Text;
using WebCoreShop.Data.Enums;

namespace WebCoreShop.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
