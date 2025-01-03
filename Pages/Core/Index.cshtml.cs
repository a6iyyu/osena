using Microsoft.AspNetCore.Mvc.RazorPages;
using osena.Pages.Components.Beranda;
namespace osena.Pages.Core;

public class IndexModel : PageModel
{
    public Keuntungan.Props? Keuntungan { get; set; }
    public BagaimanaKamiBekerja.Props? BagaimanaKamiBekerja { get; set; }

    public void OnGet()
    {
        Keuntungan = new Keuntungan.Props();
        BagaimanaKamiBekerja = new BagaimanaKamiBekerja.Props();
    }
}