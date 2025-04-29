using System.ComponentModel.DataAnnotations;

namespace StudentAffairs.Models
{
    public class Lecture
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required]
        [Display(Name = "Instructor Name")]
        public string InstructorName { get; set; }

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
        [Display(Name = "Room Number")]
        public string RoomNumber { get; set; }
    }
} 