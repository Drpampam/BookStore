using BookStore.Data.Interface;
using BookStore.Helpers.Common;
using BookStore.Model.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        [Route("books")]
        [Authorize]
        public async Task<IActionResult> GetAllBooks([FromQuery] FilterClass filterClass)
        {
            var books = await _bookRepository.GetAllAsync(filterClass);
            return Ok(books);
        }

        [HttpPost]
        [Route("books")]
        public async Task<ActionResult> AddBooks([FromBody] Book book)
        {
            await _bookRepository.AddBookAsync(book);
            return CreatedAtAction("GetAllBooks", new
            {
                Id = book.Id
            },
            book);
        }

        [HttpPut]
        [Route("book/{id:int}")]
        public async Task<ActionResult> UpdateBook(int id, [FromBody] Book book)
        {
            try
            {
                await _bookRepository.UpdateBook(id, book);
            }
            catch (Exception)
            {
                return BadRequest("Information Not Found");
            }
            return NoContent();
        }

        [HttpDelete]
        [Route("book/{id:int}")]
        public async Task<ActionResult> DeleteBook(int id)
        {
            var result = await _bookRepository.DeleteBookAsync(id);
            if (!result)
                return BadRequest("No book exist for this id");
            return NoContent();
        }
    }
}
