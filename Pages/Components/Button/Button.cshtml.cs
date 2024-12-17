using Microsoft.AspNetCore.Mvc;
namespace osena.Pages.Components.Button;

public class Button : ViewComponent
{
    public IViewComponentResult Invoke(string Name, string Link, string Styling)
    {
        ViewData["Name"] = Name;
        ViewData["Link"] = Link;
        ViewData["Styling"] = Styling;

        return View();
    }
}