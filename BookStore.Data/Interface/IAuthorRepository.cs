using BookStore.Helpers.Common;
using BookStore.Model.Entities;

namespace BookStore.Data.Interface
{
    public interface IAuthorRepository
    {
        Task <IEnumerable<Author>> GetAllAsync(Paginator paginator);
        Task <Author> GetAsync(int id);
    }
}
