using CAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CAPP.Infrastructure.Persistence.Configurations
{
    public class OperationConfiguration : IEntityTypeConfiguration<Operation>
    {
        public void Configure(EntityTypeBuilder<Operation> builder)
        {
            builder.HasKey(o => o.Id);

            builder.HasIndex(o => o.Code)
                .IsUnique();

            builder.Property(o => o.Code)
                .HasColumnType("nvarchar(255)")
                .IsRequired();

            builder.Property(o => o.KeyWord)
                .HasColumnType("nvarchar(255)")
                .IsRequired();
        }
    }
}
