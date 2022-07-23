using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Person
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string? FirstMidName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Full Name")]
        public string? FullName
        {
            get {return LastName + ' ' + FirstMidName;}
        }
    }
}
