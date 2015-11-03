namespace StudentSystem.Api.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using StudentSystem.Models;

    public class StudentApiModel
    {             
        [Required]
        [MinLength(10)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Range(1, 100000)]
        [Required]
        public int Number { get; set; }

        public ICollection<Course> Courses;
    }
}
