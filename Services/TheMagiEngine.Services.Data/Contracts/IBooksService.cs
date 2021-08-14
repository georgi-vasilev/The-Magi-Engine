namespace TheMagiEngine.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using TheMagiEngine.Web.ViewModels.Books;

    public interface IBooksService
    {
        Task CreateAsync(CreateBookInputModel input);

        IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12);

        IEnumerable<T> GetRandom<T>(int count);

        int GetCount();

        T GetById<T>(string id);

        Task UpdateAsync(string id, EditBookInputModel model);

        Task DeleteAsync(string id);

        IEnumerable<T> GetByAuthor<T>(IEnumerable<string> authorIds);
    }
}
