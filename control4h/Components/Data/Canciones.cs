using System.ComponentModel.DataAnnotations;
namespace control4h.Components.Data
{
    public class Canciones
    {
        [Required(ErrorMessage = "Agrega el nombre de la cancion")]
        public string? Cancion { get; set; }
    }
}
