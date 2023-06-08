using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaOficinas.Models
{
    [Table("Fabricante")]
    public class FabricanteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   // Passa o Campo Id com Auto-Incremento
        public int FabricanteId { get; set; }

        [StringLength(20)]
        public string? FabricanteNome { get; set; }
    }
}
