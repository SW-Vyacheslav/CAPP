using CAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CAPP.Infrastructure.Persistence.Configurations
{
    public class OperationObjectConfiguration : IEntityTypeConfiguration<OperationObject>
    {
        public void Configure(EntityTypeBuilder<OperationObject> builder)
        {
            builder.HasKey(o => o.Id);

            builder.HasIndex(o => o.Code)
                .IsUnique();

            builder.Property(o => o.Code)
                .HasColumnType("nvarchar(255)")
                .IsRequired();

            builder.Property(o => o.Name)
                .HasColumnType("nvarchar(255)")
                .IsRequired();
        }
    }
}
