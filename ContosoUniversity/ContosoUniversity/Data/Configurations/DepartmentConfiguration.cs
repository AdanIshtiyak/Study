using ContosoUniversity.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContosoUniversity.Data.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {


        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();

            builder.HasOne(x => x.Administrator).WithOne(x => x.Department).IsRequired();

            builder.Property(p => p.RowVersion).IsConcurrencyToken();

            builder.HasData(new Department
            {
                ID = 1,
                Name = "English",
                Budget = 350000,
                StartDate = DateTime.Parse("2007-09-01"),
                InstructorID = 1
            },
                new Department
                {
                    ID = 2,
                    Name = "Mathematics",
                    Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = 2
                },
                new Department
                {
                    ID = 3,
                    Name = "Engineering",
                    Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = 3
                },
                new Department
                {
                    ID = 4,
                    Name = "Economics",
                    Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = 4
                }) ;
        }
    }
}
