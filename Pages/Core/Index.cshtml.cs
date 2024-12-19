using Microsoft.AspNetCore.Mvc.RazorPages;
using osena.Pages.Components.Beranda;
namespace osena.Pages.Core;

public class IndexModel : PageModel
{
    public Keuntungan.KeuntunganProps? KeuntunganProps { get; set; }

    public void OnGet()
    {
        KeuntunganProps = new Keuntungan.KeuntunganProps();
    }
}