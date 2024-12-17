using Microsoft.AspNetCore.Mvc.RazorPages;

namespace osena.Pages.Shared
{
    public class FooterModel : PageModel
    {
        public List<string> Menus { get; set; }

        public FooterModel() {
            Menus = [];
        }
    }
}