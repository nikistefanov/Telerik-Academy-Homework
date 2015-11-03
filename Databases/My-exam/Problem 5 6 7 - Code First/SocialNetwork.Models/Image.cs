namespace SocialNetwork.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Image
    {
        public int Id { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        [MaxLength(4)]
        public string FileExtension { get; set; }
    }
}
