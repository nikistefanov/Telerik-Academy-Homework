namespace SocialNetwork.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Friendship
    {
        [Required]
        public UserProfile FirstUser { get; set; }

        [Required]
        public UserProfile SecondUser { get; set; }
    }
}
