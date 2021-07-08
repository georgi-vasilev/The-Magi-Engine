namespace TheMagiEngine.Data.Models
{
    using System;
    using System.Collections.Generic;

    using TheMagiEngine.Data.Common.Models;

    public class Book : BaseDeletableModel<string>
    {
        public Book()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Author = new HashSet<BookAuthor>();
            this.Images = new HashSet<Image>();
            this.Wishlist = new HashSet<WishlistBook>();
        }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public int Pages { get; set; }

        public int Year { get; set; }

        public virtual ICollection<BookAuthor> Author { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<WishlistBook> Wishlist { get; set; }
    }
}
