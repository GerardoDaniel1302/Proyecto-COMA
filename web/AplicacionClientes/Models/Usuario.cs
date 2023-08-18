using System.ComponentModel.DataAnnotations;

namespace AplicacionClientes.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Nombre")]
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Apellido { get; set; }

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "La edad es obligatorio")]
        public int Edad { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "El correo es obligatorio")]
        public string Correo_electronico { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "El tipo de usuario es obligatorio")]
        public string Tipo_usuario { get; set; }
    }
}
