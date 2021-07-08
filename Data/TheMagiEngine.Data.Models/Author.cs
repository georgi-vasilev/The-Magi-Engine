namespace TheMagiEngine.Data.Models
{
    using System;
    using System.Collections.Generic;

    using TheMagiEngine.Data.Common.Models;

    public class Author : BaseModel<string>
    {
        public Author()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Books = new HashSet<BookAuthor>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<BookAuthor> Books { get; set; }
    }
}