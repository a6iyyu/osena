using Microsoft.AspNetCore.Mvc.RazorPages;

namespace osena.Pages.Shared
{
    public class HeaderModel : PageModel
    {
        public List<string> Menus { get; set; }

        public HeaderModel()
        {
            Menus = ["Artikel", "Kemitraan", "Konsultasi", "Masuk"];
        }
    }
}