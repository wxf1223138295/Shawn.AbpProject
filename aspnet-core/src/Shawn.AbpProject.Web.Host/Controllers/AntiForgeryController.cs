using Microsoft.AspNetCore.Antiforgery;
using Shawn.AbpProject.Controllers;

namespace Shawn.AbpProject.Web.Host.Controllers
{
    public class AntiForgeryController : AbpProjectControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
