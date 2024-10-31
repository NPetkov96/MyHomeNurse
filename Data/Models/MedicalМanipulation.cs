using Microsoft.EntityFrameworkCore;
using MyHomeNurse.Common;
using System.ComponentModel.DataAnnotations;

namespace MyHomeNurse.Data.Models
{
    public class MedicalМanipulation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("Manipulation type")]
        public string ManipulationName { get; set; } = null!; 

        [Required]
        [Comment("Price per manipulation")]
        public decimal Price { get; set; }

        [Comment("Notes for manipulation if it's needed")]
        [MaxLength(ManipulationConstants.MaxNoteArray)]
        public string? Note { get; set; }
    }
}
