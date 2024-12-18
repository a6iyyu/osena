using Microsoft.AspNetCore.Mvc;
namespace osena.Pages.Shared.HamburgerMenu;

public class HamburgerMenuModel : ViewComponent
{
    public IViewComponentResult Invoke(string IsShow)
    {
        ViewData["IsShow"] = IsShow;

        return View();
    }
}