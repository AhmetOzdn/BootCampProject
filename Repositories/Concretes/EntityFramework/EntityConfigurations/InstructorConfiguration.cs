using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Concretes.EntityFramework.EntityConfigurations
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors");
            builder.Property(x => x.CompanyName).HasColumnName("CompanyName").IsRequired();
            builder.HasMany(x => x.Bootcamps);
        }
    }
}
