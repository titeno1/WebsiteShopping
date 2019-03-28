using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebCoreShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    //bat buoc phai login
    [Authorize]
    public class BaseController : Controller
    {
        
       
    }
}