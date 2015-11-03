namespace SocialNetwork.Data
{
    using SocialNetwork.Models;
    using System.Data.Entity;

    public class SocialNetworkDbContext : DbContext
    {
        public SocialNetworkDbContext()
            : base("SocialNetworkSystem")
        {
        }

        public virtual IDbSet<UserProfile> UserProfiles { get; set; }

        public virtual IDbSet<Post> Posts { get; set; }

        public virtual IDbSet<Image> Images { get; set; }

        //public virtual IDbSet<Friendship> Friendships { get; set; }
    }
}
