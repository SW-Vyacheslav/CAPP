using CAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CAPP.Infrastructure.Persistence.Configurations
{
    public class OperationGroupConfiguration : IEntityTypeConfiguration<OperationGroup>
    {
        public void Configure(EntityTypeBuilder<OperationGroup> builder)
        {
            builder.HasKey(og => og.Id);

            builder.HasIndex(og => og.Code)
                .IsUnique();

            builder.Property(og => og.Code)
                .HasColumnType("nvarchar(255)")
                .IsRequired();

            builder.Property(og => og.Name)
                .HasColumnType("nvarchar(255)")
                .IsRequired();
        }
    }
}
