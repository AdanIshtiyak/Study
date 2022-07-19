using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContosoUniversity.Data.Configurations
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(x => x.LastName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.FirstMidName).HasMaxLength(50).IsRequired();

            builder.HasData(new Instructor
            {
                ID = 1,
                FirstMidName = "Kim",
                LastName = "Abercrombie",
                HireDate = DateTime.Parse("1995-03-11")
            },
                new Instructor
                {
                    ID = 2,
                    FirstMidName = "Fadi",
                    LastName = "Fakhouri",
                    HireDate = DateTime.Parse("2002-07-06")
                },
                new Instructor
                {
                    ID = 3,
                    FirstMidName = "Roger",
                    LastName = "Harui",
                    HireDate = DateTime.Parse("1998-07-01")
                },
                new Instructor
                {
                    ID = 4,
                    FirstMidName = "Candace",
                    LastName = "Kapoor",
                    HireDate = DateTime.Parse("2001-01-15")
                },
                new Instructor
                {
                    ID = 5,
                    FirstMidName = "Roger",
                    LastName = "Zheng",
                    HireDate = DateTime.Parse("2004-02-12")
                });
        }
    }
}
