using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContosoUniversity.Data.Configurations
{
    public class CourseAssignmentConfiguration : IEntityTypeConfiguration<CourseAssignment>
    {
        public List<Course> courses;
        public List<Instructor> instructors;
        public void Configure(EntityTypeBuilder<CourseAssignment> builder)
        {
            builder.HasOne(x => x.Course).WithMany(x => x.CourseAssignments).HasForeignKey(x => x.CourseID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Instructor).WithMany(x => x.CourseAssignments).HasForeignKey(x => x.InstructorID).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(new CourseAssignment
            {
                CourseID = courses.Single(c => c.Title == "Chemistry").ID,
                InstructorID = instructors.Single(i => i.LastName == "Kapoor").ID
            },
                new CourseAssignment
                {
                    CourseID = courses.Single(c => c.Title == "Chemistry").ID,
                    InstructorID = instructors.Single(i => i.LastName == "Harui").ID
                },
                new CourseAssignment
                {
                    CourseID = courses.Single(c => c.Title == "Microeconomics").ID,
                    InstructorID = instructors.Single(i => i.LastName == "Zheng").ID
                },
                new CourseAssignment
                {
                    CourseID = courses.Single(c => c.Title == "Macroeconomics").ID,
                    InstructorID = instructors.Single(i => i.LastName == "Zheng").ID
                },
                new CourseAssignment
                {
                    CourseID = courses.Single(c => c.Title == "Calculus").ID,
                    InstructorID = instructors.Single(i => i.LastName == "Fakhouri").ID
                },
                new CourseAssignment
                {
                    CourseID = courses.Single(c => c.Title == "Trigonometry").ID,
                    InstructorID = instructors.Single(i => i.LastName == "Harui").ID
                },
                new CourseAssignment
                {
                    CourseID = courses.Single(c => c.Title == "Composition").ID,
                    InstructorID = instructors.Single(i => i.LastName == "Abercrombie").ID
                },
                new CourseAssignment
                {
                    CourseID = courses.Single(c => c.Title == "Literature").ID,
                    InstructorID = instructors.Single(i => i.LastName == "Abercrombie").ID
                });
        }
    }
}
