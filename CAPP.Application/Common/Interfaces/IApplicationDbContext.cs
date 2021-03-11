using CAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CAPP.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<OperationGroup> OperationGroups { get; set; }

        DbSet<OperationObject> OperationObjects { get; set; }

        DbSet<Operation> Operations { get; set; }

        DbSet<OperationGroupOperation> OperationGroupOperations { get; set; }

        DbSet<OperationOperationObject> OperationOperationObjects { get; set; }
    }
}
