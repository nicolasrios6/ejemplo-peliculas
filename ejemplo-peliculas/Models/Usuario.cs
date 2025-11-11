using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ejemplo_peliculas.Models
{
    public class Usuario : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        public string ImagenPerfilUrl { get; set; }
        public List<Favorito> PeliculasFavoritas { get; set; }
        public List<Review>? ReviewsUsuario { get; set; }
    }

    public class RegistroViewModel
    {
        [Required(ErrorMessage = "Debes ingresar un Nombre.")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debes ingresar un Apellido.")]
        [StringLength(50)]
        public string Apellido { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "El email es obligatorio")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "La clave es obligatoria.")]
        [Compare("Clave", ErrorMessage = "Las claves no coinciden.")]
        public string Clave { get; set; }
        [DataType(DataType.Password)]
        public string ConfirmarClave { get; set; }
    }

    public class LoginViewModel
    {
        [EmailAddress(ErrorMessage = "Ingresa un email válido.")]
        [Required(ErrorMessage = "El email es obligatorio")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "La clave es obligatoria.")]
        public string Clave { get; set; }
        public bool Recordarme { get; set; }
    }
}