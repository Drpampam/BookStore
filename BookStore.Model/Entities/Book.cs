using BookStore.Model.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Model.Entities
{
    public class Book
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public Genre BookGenre { get; set; }
        public bool BestSeller { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Price { get; set; }

        [ForeignKey("author")]
        public int AuthorId { get; set; }
    }
}
