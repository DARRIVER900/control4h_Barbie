using System.ComponentModel.DataAnnotations;

namespace control4h.Components.Data
{
    public class Persona // clase publica que se puede usar de cualquier parte desde nuestro proyecto
    {
        [Required(ErrorMessage = "El nombre es obligatorio")] // Con este required indicas que el dato o el campo debe ser obligatorio
        [MaxLength(20, ErrorMessage = "El nombre deber tener menos de 20 caracteres")]
        public string? Nombre { get; set; } // creamos propiedades (el signo de interrogacion te dice que los valores pueden ser nulos)
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe tener un correo valido")]
        public string? Correo { get; set; }
        [Range(10, 120, ErrorMessage = "El rango de edad es 10-120")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Debes elegir un genero")]
        public string? Genero { get; set; }
    }
}
