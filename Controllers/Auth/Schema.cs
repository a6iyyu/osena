using System.ComponentModel.DataAnnotations;
namespace osena.Controllers.Auth;

public class User
{
    [Required(ErrorMessage = "Nama pengguna tidak boleh kosong!")]
    [StringLength(25, ErrorMessage = "Nama pengguna harus memiliki 25 karakter!")]
    [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Nama pengguna hanya boleh berisi huruf, angka, dan garis bawah!")]
    public required string? Username { get; set; }

    [Required(ErrorMessage = "Surel tidak boleh kosong!")]
    [EmailAddress(ErrorMessage = "Surel tidak valid!")]
    public required string? Email { get; set; }

    [Required(ErrorMessage = "Kata sandi tidak boleh kosong!")]
    [MinLength(8, ErrorMessage = "Kata sandi minimal 8 karakter!")]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*\d).{7,}$", ErrorMessage = "Kata sandi harus memiliki setidaknya 7 karakter, 1 huruf besar, dan 1 angka!")]
    public required string? Password { get; set; }

    [Required(ErrorMessage = "Konfirmasi kata sandi tidak boleh kosong!")]
    [Compare("Password", ErrorMessage = "Kata sandi tidak cocok!")]
    public required string? ConfirmPassword { get; set; }
}