using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Shawn.AbpProject.Controllers;

namespace Shawn.AbpProject.Web.Host.Controllers
{
    [Authorize]
    public class LoginTestController: AbpProjectControllerBase
    {
        public  async Task<IActionResult> Test()
        {
            var result="";
            return Json(result);
        }
    }
}
