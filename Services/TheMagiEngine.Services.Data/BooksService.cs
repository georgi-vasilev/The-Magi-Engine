namespace TheMagiEngine.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TheMagiEngine.Services.Data.Contracts;
    using TheMagiEngine.Web.ViewModels.Books;

    public class BooksService : IBooksService
    {
        public Task CreateAsync(CreateBookInputModel input)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetByAuthor<T>(IEnumerable<string> authorIds)
        {
            throw new System.NotImplementedException();
        }

        public T GetById<T>(string id)
        {
            throw new System.NotImplementedException();
        }

        public int GetCount()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetRandom<T>(int count)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(string id, EditBookInputModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}
