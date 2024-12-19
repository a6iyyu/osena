namespace osena.Pages.Shared.Sidebar;

public class Sidebar
{
    public SidebarProps? _SidebarProps { get; set; }

    public class Metadata
    {
        public string? Icon { get; set; }
        public string? Title { get; set; }
    }

    public class SidebarProps
    {
        public List<Metadata> Sidebar { get; set; } =
        [
            new()
            {
                Icon = "fas fa-newspaper",
                Title = "Artikel",
            },
            new()
            {
                Icon = "fa-solid fa-handshake",
                Title = "Kemitraan",
            },
            new()
            {
                Icon = "fa-solid fa-business-time",
                Title = "Konsultasi",
            },
            new()
            {
                Icon = "fa fa-sign-in",
                Title = "Masuk",
            }
        ];
    }
}