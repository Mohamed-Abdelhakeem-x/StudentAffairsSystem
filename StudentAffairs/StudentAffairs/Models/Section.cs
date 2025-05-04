using System.ComponentModel.DataAnnotations;

namespace StudentAffairs.Models
{
    public class Section
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required]
        [Display(Name = "Teaching Assistant")]
        public string TeachingAssistant { get; set; }

        [Required]
        [Display(Name = "Day of Week")]
        public DayOfWeek DayOfWeek { get; set; }

        [Required]
        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }

        [Required]
        [Display(Name = "End Time")]
        [DataType(DataType.Time)]
        public TimeSpan EndTime { get; set; }

        [Required]
        [Display(Name = "Lab Number")]
        public string LabNumber { get; set; }

        [Required]
        [Display(Name = "Student Year")]
        [Range(1, 4, ErrorMessage = "Student year must be between 1 and 4")]
        public int StudentYear { get; set; }
    }
}