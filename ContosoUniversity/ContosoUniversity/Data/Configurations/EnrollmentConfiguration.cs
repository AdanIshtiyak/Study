using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContosoUniversity.Data.Configurations
{
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasOne(x => x.Student).WithMany(x => x.Enrollments).HasForeignKey(x => x.StudentID);
            builder.HasOne(x => x.Course).WithMany(x => x.Enrollments).HasForeignKey(x => x.CourseID);

            builder.HasData(new Enrollment
            {
                ID = 1,
                StudentID = 1,
                CourseID = 1050,
                Grade = Grade.A
            },
                    new Enrollment
                    {
                        ID = 2,
                        StudentID = 2,
                        CourseID = 1050,
                        Grade = Grade.C
                    },
                    new Enrollment
                    {
                        ID = 3,
                        StudentID = 3,
                        CourseID = 4022,
                        Grade = Grade.B
                    },
                    new Enrollment
                    {
                        ID = 4,
                        StudentID = 4,
                        CourseID = 4041,
                        Grade = Grade.B
                    },
                    new Enrollment
                    {
                        ID = 5,
                        StudentID = 5,
                        CourseID = 1045,
                        Grade = Grade.B
                    },
                    new Enrollment
                    {
                        ID = 6,
                        StudentID = 6,
                        CourseID = 2021,
                        Grade = Grade.B
                    },
                    new Enrollment
                    {
                        ID = 7,
                        StudentID = 7,
                        CourseID = 3141
                    },
                    new Enrollment
                    {
                        ID = 8,
                        StudentID = 8,
                        CourseID = 2042,
                        Grade = Grade.B
                    },
                new Enrollment
                {
                    ID = 9,
                    StudentID = 1,
                    CourseID = 4022,
                    Grade = Grade.B
                },
                    new Enrollment
                    {
                        ID = 10,
                        StudentID = 2,
                        CourseID = 4041,
                        Grade = Grade.B
                    },
                    new Enrollment
                    {
                        ID = 11,
                        StudentID = 3,
                        CourseID = 1045,
                        Grade = Grade.B
                    });
        }
    }
}
