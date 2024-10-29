using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MathiasVera_ExamenP1.Models
{
    public class MathiasVera
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Es necesario de llenar el promedio")]
        public decimal Promedio { get; set; }
        [EmailAddress]
        [MaxLength(70, ErrorMessage = "Ha excedido la cantidad maxima de caracteres")]
        public string Correo { get; set; }
        [AllowNull]
        public bool TieneBeca { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
