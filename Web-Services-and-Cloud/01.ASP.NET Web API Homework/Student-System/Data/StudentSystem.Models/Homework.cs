namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Homework
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(10000)]
        public string Content { get; set; }

        [Required]
        [Range(0, 10000)]
        public int TimeSpendMinutes { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
