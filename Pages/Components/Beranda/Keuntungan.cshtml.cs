namespace osena.Pages.Components.Beranda;

public class Keuntungan
{
    public class Metadata
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Styling { get; set; }
    }

    public class Props
    {
        public List<Metadata> Keuntungan { get; set; } =
        [
            new()
            {
                Name = "Dukungan Secara Daring",
                Description = "Kami menyediakan bantuan pelanggan 24/7 melalui platform daring.",
                Styling = "fa-solid fa-phone-volume p-4 rounded-full bg-green-200/75 text-green-600",
            },
            new()
            {
                Name = "Perencanaan Strategis",
                Description = "Kami menawarkan solusi strategis untuk membantu bisnis Anda mencapai kesuksesan.",
                Styling = "fa-solid fa-rocket p-4 rounded-full bg-pink-200/75 text-pink-600",
            },
            new()
            {
                Name = "Solusi Inovatif",
                Description = "Inovasi teknologi modern yang membantu bisnis Anda tetap unggul.",
                Styling = "fa-solid fa-bolt p-4 rounded-full bg-blue-200/75 text-blue-600",
            },
            new()
            {
                Name = "Aman dan Terjamin",
                Description = "Keamanan data dan privasi pelanggan adalah prioritas utama kami.",
                Styling = "fa-solid fa-shield p-4 rounded-full bg-amber-200/75 text-amber-600",
            }
        ];
    }
}