using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Concretes.EntityFramework.EntityConfigurations
{
    public class BootcampConfiguration:IEntityTypeConfiguration<Bootcamp>
    {
        public void Configure(EntityTypeBuilder<Bootcamp> builder)
        {
            builder.ToTable("Bootcamp");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).HasColumnName("Id").IsRequired();
            builder.Property(x => x.Name).HasColumnName("Name").IsRequired();
            builder.Property(x => x.InstructorId).HasColumnName("InstructorId").IsRequired();
            builder.Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            builder.Property(x => x.EndDate).HasColumnName("EndDate").IsRequired();
            builder.Property(x => x.BootcampState).HasColumnName("BootcampState").IsRequired();
            builder.Property(x => x.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            builder.Property(x => x.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(x => x.DeletedDate).HasColumnName("DeletedDate");

            builder.HasMany(x => x.Instructors);
        }
    }
}
