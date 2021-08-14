namespace TheMagiEngine.Web.ViewModels.Author
{
    using System.Collections.Generic;

    using TheMagiEngine.Data.Models;
    using TheMagiEngine.Services.Mapping;

    public class EditAuthorInputModel : IMapFrom<Author>
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IEnumerable<BookAuthor> Books { get; set; }
    }
}
