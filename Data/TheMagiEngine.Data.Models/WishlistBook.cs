namespace TheMagiEngine.Data.Models
{
    public class WishlistBook
    {
        public int Id { get; set; }

        public string BookId { get; set; }

        public virtual Book Book { get; set; }

        public string WishlistId { get; set; }

        public virtual Wishlist Wishlist { get; set; }
    }
}