namespace TheMagiEngine.Data.Models
{
    using System;

    using TheMagiEngine.Data.Common.Models;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Extension { get; set; }

        public string RemoteImageUrl { get; set; }

        public string CreaterId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public string BookId { get; set; }

        public virtual Book Book { get; set; }
    }
}
