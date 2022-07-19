using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContosoUniversity.Data.Configurations
{
    public class OfficeAssignmentConfiguration : IEntityTypeConfiguration<OfficeAssignment>
    {
        private List<Instructor> instructors = new List<Instructor>();
        public void Configure(EntityTypeBuilder<OfficeAssignment> builder)
        {
            builder.Property(x => x.Location).HasMaxLength(50);

            builder.HasOne(x => x.Instructor).WithOne(x => x.OfficeAssignment).IsRequired(false);

            builder.HasData(new OfficeAssignment
            {
                InstructorID = 1,
                Location = "Smith 17"
            },
            new OfficeAssignment
            {
                InstructorID = 2,
                Location = "Gowan 27"
            },
                new OfficeAssignment
                {
                    InstructorID = 3,
                    Location = "Thompson 304"
                });
        }
    }
}
