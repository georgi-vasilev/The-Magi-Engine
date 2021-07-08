namespace TheMagiEngine.Data.Models
{
    using System;
    using System.Collections.Generic;

    using TheMagiEngine.Data.Common.Models;

    public class Wishlist : BaseDeletableModel<string>
    {
        public Wishlist()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Books = new HashSet<WishlistBook>();
        }

        public string UserId { get; set; }

        public virtual ApplicationUser UserWishlist { get; set; }

        public virtual ICollection<WishlistBook> Books { get; set; }
    }
}
