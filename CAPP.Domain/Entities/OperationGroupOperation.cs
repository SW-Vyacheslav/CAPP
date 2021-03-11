namespace CAPP.Domain.Entities
{
    public class OperationGroupOperation
    {
        public int Id { get; set; }
        
        public int OperationGroupId { get; set; }
        
        public int OperationId { get; set; }

        public OperationGroup OperationGroup { get; set; }

        public Operation Operation { get; set; }
    }
}
