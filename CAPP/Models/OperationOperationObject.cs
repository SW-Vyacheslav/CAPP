using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CAPP.Models
{
    [Table("OperationOperationObjects")]
    public class OperationOperationObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Operation")]
        public int OperationId { get; set; }

        [ForeignKey("OperationObject")]
        public int OperationObjectId { get; set; }

        public virtual Operation Operation { get; set; }

        public virtual OperationObject OperationObject { get; set; }
    }
}
