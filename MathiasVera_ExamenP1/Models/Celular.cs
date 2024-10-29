using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MathiasVera_ExamenP1.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Modelo { get; set; }
        [DisplayName("Año del modelo")]
        public int Año { get; set; }
        [NotNull]
        [Range(0, 1000)]
        public decimal Precio { get; set; }
        public MathiasVera Propietario { get; set; }
        [ForeignKey("MathiasVera")]
        public int MathiasVeraId { get; set; }

    }
}
