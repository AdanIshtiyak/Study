using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContosoUniversity.Data.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(50).IsRequired();

            builder.HasOne(x => x.Department).WithMany(x => x.Courses).HasForeignKey(x => x.DepartmentID);

            builder.HasData(new Course
            {
                ID = 1050,
                Title = "Chemistry",
                Credits = 3,
                DepartmentID = 1
            },
                new Course
                {
                    ID = 4022,
                    Title = "Microeconomics",
                    Credits = 3,
                    DepartmentID = 2
                },
                new Course
                {
                    ID = 4041,
                    Title = "Macroeconomics",
                    Credits = 3,
                    DepartmentID = 3
                },
                new Course
                {
                    ID = 1045,
                    Title = "Calculus",
                    Credits = 4,
                    DepartmentID = 4
                },
                new Course
                {
                    ID = 3141,
                    Title = "Trigonometry",
                    Credits = 4,
                    DepartmentID = 1
                },
                new Course
                {
                    ID = 2021,
                    Title = "Composition",
                    Credits = 3,
                    DepartmentID = 2
                },
                new Course
                {
                    ID = 2042,
                    Title = "Literature",
                    Credits = 4,
                    DepartmentID = 3
                });
        }
    }
}
