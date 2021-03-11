namespace CAPP.Domain.Entities
{
    public class OperationOperationObject
    {
        public int Id { get; set; }

        public int OperationId { get; set; }
        
        public int OperationObjectId { get; set; }

        public Operation Operation { get; set; }

        public OperationObject OperationObject { get; set; }
    }
}
