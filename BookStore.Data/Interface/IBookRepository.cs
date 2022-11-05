using BookStore.Helpers.Common;
using BookStore.Model.Entities;

namespace BookStore.Data.Interface
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllAsync(FilterClass filterClass);
        Task<Book> GetAsync(int id);
        Task <Book> AddBookAsync (Book book);
        Task<bool> DeleteBookAsync (int id);
        Task UpdateBook(int id, Book book);
    }
}
