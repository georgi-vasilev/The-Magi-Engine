namespace TheMagiEngine.Web.ViewModels.Books
{
    using TheMagiEngine.Data.Models;
    using TheMagiEngine.Services.Mapping;

    public class CreateBookInputModel : IMapFrom<Book>
    {
        public string Title { get; set; }

        public string SubTitle { get; set; }

        public int Pages { get; set; }

        public int Year { get; set; }

        public string AuthorId { get; set; }
    }
}
