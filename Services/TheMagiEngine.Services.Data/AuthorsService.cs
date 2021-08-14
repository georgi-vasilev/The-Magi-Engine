namespace TheMagiEngine.Services.Data
{
    using System.Threading.Tasks;

    using TheMagiEngine.Services.Data.Contracts;
    using TheMagiEngine.Web.ViewModels.Author;

    public class AuthorsService : IAuthorsService
    {
        public Task CreateAsync(CreateAuthorInputModel model)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(string id, EditAuthorInputModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}
