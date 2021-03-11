using CAPP.Application.Common.Interfaces;
using CAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CAPP.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {      
        public DbSet<OperationGroup> OperationGroups { get; set; }

        public DbSet<OperationObject> OperationObjects { get; set; }

        public DbSet<Operation> Operations { get; set; }

        public DbSet<OperationGroupOperation> OperationGroupOperations { get; set; }

        public DbSet<OperationOperationObject> OperationOperationObjects { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
