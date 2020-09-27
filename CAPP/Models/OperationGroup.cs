using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAPP.Models
{
    [Table("OperationGroups")]
    public class OperationGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [Column(TypeName = "NVARCHAR(255)")]
        public string Code { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(255)")]
        public string Name { get; set; }
    }
}
