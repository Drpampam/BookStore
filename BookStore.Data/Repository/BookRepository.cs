using BookStore.Data.Interface;
using BookStore.Helpers.Common;
using BookStore.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace BookStore.Data.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Book> AddBookAsync(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task UpdateBook(int id, Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            _context.Books.Update(book);
            if (book == null)
            {
                throw new Exception("Not Found");
            }
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteBookAsync(int id)
        {
            try
            {
                var book = await _context.Books.FindAsync(id);
                if (book != null)
                    _context.Books.Remove(book);
                else
                    return false;
            }
            catch (DbException)
            {
                throw new Exception("System error");
            }
            _context.SaveChanges();
            return true;
        }

        public async Task<IEnumerable<Book>> GetAllAsync(FilterClass filterClass)
        {
            IQueryable<Book> books = _context.Books.AsQueryable();

            //filterring by Filterclass using Genre and max/min price
            if (filterClass.MinPrice >= 0 && filterClass.MaxPrice > 0)
            {
                books = books.Where(b => b.Price >= filterClass.MinPrice && b.Price <= filterClass.MaxPrice);
            }
            //    if (filterClass.BookGenre != null)
            //        books = books.Where(b => string.Equals(b.BookGenre.ToString().ToLower(), filterClass.BookGenre.ToString(),
            //StringComparison.CurrentCultureIgnoreCase));

            //To Search or Filter by Title
            if (filterClass.Title == null)
            {
                books = books.Where(b => b.Title.ToString().ToLower().Contains(filterClass.Title.ToLower()));
            }
            //for paginator... remember that filterclass is inheriting from paginator class
            if (filterClass.Size > 0)
            {
                books.Skip(filterClass.Size * filterClass.Page - 1)
                .Take(filterClass.Size);
            }
            return await books.ToArrayAsync();

            //if (user == null) return Enumerable.Empty<Book>();
        }

        public async Task<Book> GetAsync(int id)
        {
            var books = await _context.Books.FirstOrDefaultAsync(x => x.Id == id);
            if (books == null)
                return books ?? new Book();
            return books;
        }
    }
}
