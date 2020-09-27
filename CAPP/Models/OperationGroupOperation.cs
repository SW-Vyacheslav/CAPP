using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAPP.Models
{
    [Table("OperationGroupOperations")]
    public class OperationGroupOperation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("OperationGroup")]
        public int OperationGroupId { get; set; }

        [ForeignKey("Operation")]
        public int OperationId { get; set; }

        public virtual OperationGroup OperationGroup { get; set; }

        public virtual Operation Operation { get; set; }
    }
}
