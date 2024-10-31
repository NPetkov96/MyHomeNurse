using Microsoft.EntityFrameworkCore;
using MyHomeNurse.Common;
using System.ComponentModel.DataAnnotations;

namespace MyHomeNurse.Data.Models
{
    public class Nurse
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NurseConstants.MaxNameLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(NurseConstants.MaxNameLength)]
        public string LastName { get; set; } = null!;

        [Required]
        public int Age { get; set; }

        [Required]
        [Comment("Min years of experience of the nurse")]
        public int YearExperience { get; set; }

    }
}
