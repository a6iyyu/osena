using Microsoft.AspNetCore.Mvc;
namespace osena.Pages.Components.Card;

public class Card : ViewComponent
{
    public IViewComponentResult Invoke(string Title, string Description, string Link, string Image, string Styling)
    {
        ViewData["Title"] = Title;
        ViewData["Description"] = Description;
        ViewData["Link"] = Link;
        ViewData["Image"] = Image;
        ViewData["Styling"] = Styling;

        return View();
    }
}