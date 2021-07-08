namespace TheMagiEngine.Data.Models
{
    public class LikedMembership
    {
        public int Id { get; set; }

        public string MembershipId { get; set; }

        public virtual Membership Membership { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser LikedByUser { get; set; }
    }
}