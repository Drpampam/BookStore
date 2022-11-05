using BookStore.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public static class Seeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, FirstName = "Amir", LastName = "Shakur", BookId = 2, DateOfBirth = DateTime.Parse("1992-08-12") },
                new Author { Id = 2, FirstName = "Alli", LastName = "Rulby", BookId = 1, DateOfBirth = DateTime.Parse("1962-02-18") },
                new Author { Id = 3, FirstName = "Hobbs", LastName = "Tru", BookId = 5, DateOfBirth = DateTime.Parse("1990-08-08") },
                new Author { Id = 4, FirstName = "William", LastName = "Davids", BookId = 2, DateOfBirth = DateTime.Parse("1990-05-12") },
                new Author { Id = 5, FirstName = "Dan", LastName = "Sinns", BookId = 3, DateOfBirth = DateTime.Parse("1964-09-29") },
                new Author { Id = 6, FirstName = "Connel", LastName = "MonRoe", BookId = 8, DateOfBirth = DateTime.Parse("1996-07-12") },
                new Author { Id = 7, FirstName = "Ruth", LastName = "Pennylop", BookId = 5, DateOfBirth = DateTime.Parse("1990-01-12") },
                new Author { Id = 9, FirstName = "Akin", LastName = "Brown", BookId = 4, DateOfBirth = DateTime.Parse("1985-06-06") },
                new Author { Id = 8, FirstName = "Jenkins", LastName = "snyder", BookId = 1, DateOfBirth = DateTime.Parse("1980-09-26") },
                new Author { Id = 10, FirstName = "Avila", LastName = "Lawren", BookId = 7, DateOfBirth = DateTime.Parse("1991-03-06") }
                );
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, BookGenre = Model.Enum.Genre.History, Title = "Heroes of Dawn", AuthorId = 1, BestSeller = true, ReleaseDate = DateTime.Parse("2002-07-12"), Price = 60 },
                new Book { Id = 2, BookGenre = Model.Enum.Genre.Fiction, Title = "Goal With Money", AuthorId = 3, BestSeller = true, ReleaseDate = DateTime.Parse("2010-05-27"), Price = 65 },
                new Book { Id = 3, BookGenre = Model.Enum.Genre.NonFiction, Title = "Blacksmiths And Butcher", AuthorId = 1, BestSeller = false, ReleaseDate = DateTime.Parse("1999-02-01"), Price = 90 },
                new Book { Id = 4, BookGenre = Model.Enum.Genre.History, Title = "Altering The West", AuthorId = 1, BestSeller = true, ReleaseDate = DateTime.Parse("2007-06-12"), Price = 55 },
                new Book { Id = 5, BookGenre = Model.Enum.Genre.Fiction, Title = "Inventing The Void", AuthorId = 4, BestSeller = false, ReleaseDate = DateTime.Parse("2013-09-25"), Price = 75 },
                new Book { Id = 6, BookGenre = Model.Enum.Genre.NonFiction, Title = "Traitor of The Banish", AuthorId = 1, BestSeller = false, ReleaseDate = DateTime.Parse("2006-07-27"), Price = 65 },
                new Book { Id = 7, BookGenre = Model.Enum.Genre.Fiction, Title = "Crossbow of Ashwas", AuthorId = 8, BestSeller = true, ReleaseDate = DateTime.Parse("2003-03-06"), Price = 65 },
                new Book { Id = 8, BookGenre = Model.Enum.Genre.History, Title = "Heroes of America", AuthorId = 3, BestSeller = false, ReleaseDate = DateTime.Parse("2000-08-16"), Price = 85 },
                new Book { Id = 9, BookGenre = Model.Enum.Genre.Fiction, Title = "Dawn of Apes", AuthorId = 1, BestSeller = true, ReleaseDate = DateTime.Parse("2015-04-06"), Price = 115 },
                new Book { Id = 10, BookGenre = Model.Enum.Genre.NonFiction, Title = "Vampires Tale", AuthorId = 7, BestSeller = false, ReleaseDate = DateTime.Parse("2017-10-12"), Price = 65 },
                new Book { Id = 11, BookGenre = Model.Enum.Genre.NonFiction, Title = "Vampires Tale", AuthorId = 7, BestSeller = false, ReleaseDate = DateTime.Parse("2017-10-12"), Price = 45 },
                new Book { Id = 12, BookGenre = Model.Enum.Genre.History, Title = "UnHoly Truth", AuthorId = 1, BestSeller = true, ReleaseDate = DateTime.Parse("2019-01-17"), Price = 15 }
                );
        }
    }
}
