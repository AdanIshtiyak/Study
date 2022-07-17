using ContosoUniversity.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContosoUniversity.Data.Configurations
{
    public class DepartmentConfiguration: IEntityTypeConfiguration<Department>
    {
        private List<Instructor> instructors = new();

        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();

            builder.HasOne(x => x.Administrator).WithOne(x => x.Department).HasForeignKey("InstructorID").IsRequired(false);

            builder.HasData(new Department
            {
                Name = "English",
                Budget = 350000,
                StartDate = DateTime.Parse("2007-09-01"),
                InstructorID = instructors.Single(i => i.LastName == "Abercrombie").ID
            },
                new Department
                {
                    Name = "Mathematics",
                    Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = instructors.Single(i => i.LastName == "Fakhouri").ID
                },
                new Department
                {
                    Name = "Engineering",
                    Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = instructors.Single(i => i.LastName == "Harui").ID
                },
                new Department
                {
                    Name = "Economics",
                    Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = instructors.Single(i => i.LastName == "Kapoor").ID
                });
        }
    }
}
