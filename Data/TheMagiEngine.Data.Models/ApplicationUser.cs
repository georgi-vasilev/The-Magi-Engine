// ReSharper disable VirtualMemberCallInConstructor
namespace TheMagiEngine.Data.Models
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Identity;
    using TheMagiEngine.Data.Common.Models;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.LikedMemberships = new HashSet<LikedMembership>();
            this.CreatorMemberships = new HashSet<Membership>();
        }

        public string InstagramUrl { get; set; }

        public string ImageId { get; set; }

        public virtual Image CreatorImage { get; set; }

        public string MembershipId { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public virtual ICollection<LikedMembership> LikedMemberships { get; set; }

        public virtual ICollection<Membership> CreatorMemberships { get; set; }

        public string WishlistId { get; set; }

        public virtual Wishlist Wishlist { get; set; }
    }
}
