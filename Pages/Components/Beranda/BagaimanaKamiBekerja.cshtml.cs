namespace osena.Pages.Components.Beranda;

public class BagaimanaKamiBekerja
{
    public class Metadata
    {
        public string? Icon { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    public class Props
    {
        public List<Metadata> BagaimanaKamiBekerja { get; set; } =
        [
            new()
            {
                Icon = "fa-solid fa-magnifying-glass-dollar",
                Name = "Analisis Pasar Mendalam",
                Description = "Riset pasar dilakukan untuk memahami tren, kompetitor, dan kebutuhan pelanggan Anda.",
            },
            new()
            {
                Icon = "fa-solid fa-square-poll-vertical",
                Name = "Perancangan Strategi Khusus",
                Description = "Setiap bisnis memiliki kebutuhan unik. Strategi dirancang sesuai dengan kondisi dan target Anda.",
            },
            new()
            {
                Icon = "fas fa-tasks",
                Name = "Implementasi Solusi Efektif",
                Description = "Strategi yang telah dirancang diterapkan menggunakan teknologi modern dan solusi inovatif.",
            },
            new()
            {
                Icon = "fa-solid fa-microscope",
                Name = "Evaluasi Berkelanjutan",
                Description = "Hasil terus dievaluasi dengan saran pengembangan agar bisnis tetap kompetitif.",
            }
        ];
    }
}