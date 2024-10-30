using Microsoft.EntityFrameworkCore;
using MyHomeNurseCommon.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyHomeNurse.Data.Models
{
    public class Nurse
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NurseConstants.MaxLenghtName)]
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        [Required]
        [Comment("Min years of experience of the nurse")]
        public int YearExperience { get; set; }

        public int Age { get; set; }

    }
}
