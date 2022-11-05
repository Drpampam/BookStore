using BookStore.Data;
using BookStore.Data.Interface;
using BookStore.Helpers.Common;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorsController(ApplicationDbContext dbContext, IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpGet]
        [Route("authors")]
        public async Task<IActionResult> GetAllAuthors([FromQuery] Paginator paginator)
        {
            var allAuthors = await _authorRepository.GetAllAsync(paginator);
            return Ok(allAuthors);
        }

        [HttpGet]
        [Route("authors/{id:int}")]
        public async Task<IActionResult> GetAuthor(int id)
        {
            var allAuthors = await _authorRepository.GetAsync(id);
            if (allAuthors == null)
                return NotFound();
            return Ok(allAuthors);
        }
    }
}
