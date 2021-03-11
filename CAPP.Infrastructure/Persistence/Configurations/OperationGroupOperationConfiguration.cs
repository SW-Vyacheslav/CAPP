using CAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CAPP.Infrastructure.Persistence.Configurations
{
    public class OperationGroupOperationConfiguration : IEntityTypeConfiguration<OperationGroupOperation>
    {
        public void Configure(EntityTypeBuilder<OperationGroupOperation> builder)
        {
            builder.HasKey(o => o.Id);
        }
    }
}
