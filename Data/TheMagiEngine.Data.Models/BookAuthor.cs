namespace TheMagiEngine.Data.Models
{
    public class BookAuthor
    {
        public int Id { get; set; }

        public string AuthorId { get; set; }

        public virtual Author Author { get; set; }

        public string BookId { get; set; }

        public virtual Book Book { get; set; }
    }
}