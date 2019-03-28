using System;
using System.Collections.Generic;
using System.Text;

namespace WebCoreShop.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }


    }
}
