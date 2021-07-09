namespace TheMagiEngine.Data.Models
{
    using System;
    using System.Collections.Generic;

    using TheMagiEngine.Data.Common.Models;

    public class Membership : BaseDeletableModel<string>
    {
        public Membership()
        {
            this.Id = Guid.NewGuid().ToString();
            this.LikedByUser = new HashSet<LikedMembership>();
        }

        public string MembershipUrl { get; set; }

        public string Description { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public virtual ICollection<LikedMembership> LikedByUser { get; set; }
    }
}
