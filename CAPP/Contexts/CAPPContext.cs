using System.Data.Entity;
using CAPP.Models;

namespace CAPP.Contexts
{
    public class CAPPContext : DbContext
    {
        public CAPPContext() : base("CAPP_DB")
        {
            Database.SetInitializer(new CAPPContextInitializer());            
        }

        public DbSet<OperationGroup> OperationGroups { get; set; }

        public DbSet<OperationObject> OperationObjects { get; set; }

        public DbSet<Operation> Operations { get; set; }

        public DbSet<OperationGroupOperation> OperationGroupOperations { get; set; }

        public DbSet<OperationOperationObject> OperationOperationObjects { get; set; }
    }
}
