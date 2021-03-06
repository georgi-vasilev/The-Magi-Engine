namespace TheMagiEngine.Data.Models
{
    using TheMagiEngine.Data.Common.Models;

    public class Vote : BaseModel<int>
    {
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string BookId { get; set; }

        public virtual Book Book { get; set; }

        public byte Value { get; set; }
    }
}
