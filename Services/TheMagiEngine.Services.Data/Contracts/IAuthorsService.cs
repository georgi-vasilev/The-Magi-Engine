namespace TheMagiEngine.Services.Data.Contracts
{
    using System.Threading.Tasks;

    using TheMagiEngine.Web.ViewModels.Author;

    public interface IAuthorsService
    {
        Task CreateAsync(CreateAuthorInputModel model);

        Task UpdateAsync(string id, EditAuthorInputModel model);

        Task DeleteAsync(string id);
    }
}
