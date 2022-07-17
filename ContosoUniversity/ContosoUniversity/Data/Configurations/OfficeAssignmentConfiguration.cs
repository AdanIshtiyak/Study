using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContosoUniversity.Data.Configurations
{
    public class OfficeAssignmentConfiguration : IEntityTypeConfiguration<OfficeAssignment>
    {
        public List<Instructor> instructors;
        public void Configure(EntityTypeBuilder<OfficeAssignment> builder)
        {
            builder.Property(x => x.Location).HasMaxLength(50);

            builder.HasOne(x => x.Instructor).WithOne(x => x.OfficeAssignment).HasForeignKey("InstructorID").IsRequired(false);

            builder.HasData(new OfficeAssignment
            {
                InstructorID = instructors.Single(i => i.LastName == "Fakhouri").ID,
                Location = "Smith 17"
            },
                new OfficeAssignment
                {
                    InstructorID = instructors.Single(i => i.LastName == "Harui").ID,
                    Location = "Gowan 27"
                },
                new OfficeAssignment
                {
                    InstructorID = instructors.Single(i => i.LastName == "Kapoor").ID,
                    Location = "Thompson 304"
                });
        }
    }
}
