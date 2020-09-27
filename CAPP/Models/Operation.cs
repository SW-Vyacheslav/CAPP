﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAPP.Models
{
    [Table("Operations")]
    public class Operation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [Column(TypeName = "NVARCHAR(255)")]
        public string Code { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(255)")]
        public string KeyWord { get; set; }

        public virtual ICollection<OperationGroupOperation> OperationGroupOperations { get; set; }
    }
}
