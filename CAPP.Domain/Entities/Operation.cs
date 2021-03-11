using System.Collections.Generic;

namespace CAPP.Domain.Entities
{
    public class Operation
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string KeyWord { get; set; }

        public ICollection<OperationGroupOperation> OperationGroupOperations { get; set; }
    }
}
