using Microsoft.AspNetCore.Mvc.RazorPages;
namespace osena.Pages.Shared.Header;

public class HeaderModel : PageModel
{
    public List<string> Menus { get; set; }
    public Sidebar.Sidebar.Props? Sidebar { get; set; }

    public HeaderModel()
    {
        Menus = ["Artikel", "Kemitraan", "Konsultasi", "Masuk"];
        Sidebar = new Sidebar.Sidebar.Props();
    }
}