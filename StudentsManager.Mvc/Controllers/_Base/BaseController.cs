using Microsoft.AspNetCore.Mvc;

namespace StudentsManager.Mvc.Controllers._Base
{
    public class BaseController : Controller
    {
        protected IActionResult RedirectToHome()
        {
            return RedirectToAction("Index", "Home");
        }

        protected IActionResult RedirectToReturnUrl(string returnUrl)
        {
            return Url.IsLocalUrl(returnUrl) ? Redirect(returnUrl) : RedirectToHome();
        }
    }
}