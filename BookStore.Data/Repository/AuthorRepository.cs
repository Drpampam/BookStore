using BookStore.Data.Interface;
using BookStore.Helpers.Common;
using BookStore.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDbContext _context;
        public AuthorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Author> GetAsync(int id)
        {
            var author = await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);
            if (author == null)
                return author ?? new Author();
            return author;
        }

        public async Task<IEnumerable<Author>> GetAllAsync(Paginator paginator)
        {
            IQueryable<Author> authors = _context.Authors.AsQueryable();
            authors = paginator.Size > 0 ? authors.Skip(paginator.Size * paginator.Page - 1)
                .Take(paginator.Size) : authors;
            var user = await authors.ToArrayAsync();
            if (user == null) return Enumerable.Empty<Author>();
            return user;
        }
    }
}
