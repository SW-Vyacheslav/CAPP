using CAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CAPP.Infrastructure.Persistence.Configurations
{
    public class OperationOperationObjectConfiguration : IEntityTypeConfiguration<OperationOperationObject>
    {
        public void Configure(EntityTypeBuilder<OperationOperationObject> builder)
        {
            builder.HasKey(o => o.Id);
        }
    }
}
