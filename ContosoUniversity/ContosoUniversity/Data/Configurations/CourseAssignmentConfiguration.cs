using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContosoUniversity.Data.Configurations
{
    public class CourseAssignmentConfiguration : IEntityTypeConfiguration<CourseAssignment>
    {
        public void Configure(EntityTypeBuilder<CourseAssignment> builder)
        {

            builder.HasOne(x => x.Course).WithMany(x => x.CourseAssignments).HasForeignKey(x => x.CourseID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Instructor).WithMany(x => x.CourseAssignments).HasForeignKey(x => x.InstructorID).OnDelete(DeleteBehavior.NoAction);
            builder.HasKey("CourseID", "InstructorID");
            builder.HasData(new CourseAssignment
            {
                CourseID = 1050,
                InstructorID = 1
            },
                new CourseAssignment
                {
                    CourseID = 1050,
                    InstructorID = 2
                },
                new CourseAssignment
                {
                    CourseID = 4022,
                    InstructorID = 3
                },
                new CourseAssignment
                {
                    CourseID = 4041,
                    InstructorID = 4
                },
                new CourseAssignment
                {
                    CourseID = 1045,
                    InstructorID = 5
                },
                new CourseAssignment
                {
                    CourseID = 3141,
                    InstructorID = 1
                },
                new CourseAssignment
                {
                    CourseID = 2021,
                    InstructorID = 2
                },
                new CourseAssignment
                {
                    CourseID = 2042,
                    InstructorID = 3
                });
        }
    }
}
