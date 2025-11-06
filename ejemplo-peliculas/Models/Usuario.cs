using Microsoft.AspNetCore.Identity;
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
}
