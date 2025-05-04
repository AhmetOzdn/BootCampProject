using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Repositories.Concretes.EntityFramework.EntityConfigurations
{
    public class ApplicantConfiguration:IEntityTypeConfiguration<Applicant>
    {
        public void Configure(EntityTypeBuilder<Applicant> builder)
        {
            builder.ToTable("Applicants");

            builder.Property(x => x.About).HasColumnName("About").IsRequired();
        }
    }
}
