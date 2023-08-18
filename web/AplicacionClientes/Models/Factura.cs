using System.ComponentModel.DataAnnotations;
namespace AplicacionClientes.Models
{
    public class Factura
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Id de Usuario")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Id_usuario { get; set; }

        [Display(Name = "Folio")]
        [Required(ErrorMessage = "El folio es obligatorio")]
        public string Folio { get; set; }

        [Display(Name = "Saldo")]
        [Required(ErrorMessage = "El saldo es obligatorio")]
        public int Saldo { get; set; }

        [Display(Name = "Fecha Facturacion")]
        [Required(ErrorMessage = "La fecha de facturación obligatorio")]
        public DateTime Fecha_facturacion { get; set; }

        [Display(Name = "Fecha Creacion")]
        [Required(ErrorMessage = "La fecha de creación es obligatorio")]
        public DateTime Fecha_creacion { get; set; }
    }
}
