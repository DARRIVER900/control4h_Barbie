using System.ComponentModel.DataAnnotations;
namespace control4h.Components.Data
{
    public class Actividad
    {
        [Required(ErrorMessage = "Agrega la actividad")]
        public string? Actividades { get; set; }
    }
}
