namespace TheMagiEngine.Data.Models
{
    using System;
    using System.Collections.Generic;

    using TheMagiEngine.Data.Common.Models;

    public class Creator : BaseDeletableModel<string>
    {
        public Creator()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Memberships = new HashSet<Membership>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string InstagramUrl { get; set; }

        public string ImageId { get; set; }

        public virtual Image CreatorImage { get; set; }

        public string MembershipId { get; set; }

        public virtual ICollection<Membership> Memberships { get; set; }
    }
}