using PB503_Entity_Framework_homework.Models;
using System.Diagnostics.CodeAnalysis;

namespace PB503_Entity_Framework_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CreateGenre(new Genre
            //{
            //    Name = "genre1"
            //}
            //);

            //CreateGenre(new Genre
            //{
            //    Name  = "genre2"
            //}
            //);

            // Console.WriteLine(GetGenreById(1).Name); // Get Genre BY ID

            //Genre genre3 = new Genre()
            //{
            //    Name = "genre3"
            //};

            //UpdateGEnre(1, genre3);

            //foreach (var item in GetAllGenres())
            //{
            //    Console.WriteLine(item);
            //}

            //CreateBook(new Book
            //{
            //    Name = "book1",
            //    GenreId = 1,
            //    SalePrice = 5,
            //    CostPrice = 4,

            //});
            //CreateBook(new Book
            //{
            //    Name = "book2",
            //    GenreId = 2,
            //    SalePrice = 6,
            //    CostPrice = 5,

            //});

            //CreateBook(new Book
            //{
            //    Name = "book3",
            //    GenreId = 1,
            //    SalePrice = 8,
            //    CostPrice = 6,

            //});

            //CreateBook(new Book
            //{
            //    Name = "book4",
            //    GenreId = 2,
            //    SalePrice = 18,
            //    CostPrice = 16,

            //});



            //Book updatedBook = new Book()
            //{
            //    Name = "BOOK44",
            //    GenreId = 1,
            //    SalePrice = 18,
            //    CostPrice = 10
            //};
            //UpdateBook(4, updatedBook);



            //DeleteBook (2);

            //CreateBook(new Book 
            //{
            //    Name = "book123",
            //    GenreId = 2,
            //    SalePrice = 15,
            //    CostPrice = 9
            //}
            //);
            //DeleteBook (5);
            //foreach (var item in GetAllBooks())
            //{
            //    Console.WriteLine(item);
            //}

            //DeleteGenre(1);
           // Console.WriteLine("after delete");
            foreach (var item in GetAllBooks())
            {
                Console.WriteLine(item);
            }
        }

        public static void CreateGenre(Genre genre)
        {
            AppDbContext appDbContext = new AppDbContext();
            appDbContext.Genres.Add(genre);
            appDbContext.SaveChanges();
        }

        public static Genre GetGenreById(int id)
        {
            AppDbContext appDbContext = new AppDbContext();
            var wantedGenre = appDbContext.Genres.FirstOrDefault(x => x.Id == id);
            if (wantedGenre == null) throw new NullReferenceException("not found");
            return wantedGenre;
        }

        public static List<Genre> GetAllGenres()
        {
            AppDbContext dbContext = new AppDbContext();
            var genres = dbContext.Genres.ToList();
            return genres;
        }

        public static void UpdateGEnre(int id, Genre genre)
        {
            AppDbContext dbContext = new AppDbContext();
            var existGenre = dbContext.Genres.FirstOrDefault(x => x.Id == id);
            if (existGenre == null) throw new NullReferenceException();

            existGenre.Name = genre.Name;
            dbContext.SaveChanges();
        }

        public static void DeleteGenre(int id)
        {
            AppDbContext appDbContext = new AppDbContext();
            var deletedGenre = appDbContext.Genres.FirstOrDefault(x => x.Id == id);
            appDbContext.Remove(deletedGenre);
            appDbContext.SaveChanges();
        }

        public static void CreateBook(Book book)
        {
            AppDbContext context = new AppDbContext();
            context.Books.Add(book);
            context.SaveChanges();
        }

        public static Book GetBookById(int id)
        {
            AppDbContext context = new AppDbContext();
            var waqntedBook = context.Books.FirstOrDefault(x => x.Id == id);
            if (waqntedBook == null) throw new NullReferenceException();
            return waqntedBook;
        }

        public static List<Book> GetAllBooks()
        {
            AppDbContext context = new AppDbContext();
            var allBooks = context.Books.ToList();
            return allBooks;
        }

        public static void UpdateBook(int id, Book book)
        {
            AppDbContext dbContext = new AppDbContext();
            var updatedBook = dbContext.Books.FirstOrDefault(x => x.Id == id);
            if (updatedBook == null) throw new NullReferenceException();
            updatedBook.Name = book.Name;
            updatedBook.GenreId = book.GenreId;
            updatedBook.CostPrice = book.CostPrice;
            updatedBook.SalePrice = book.SalePrice;
            dbContext.SaveChanges();
        }

        public static void DeleteBook(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            var deletedBook = dbContext.Books.FirstOrDefault(x => x.Id == id);
            if (deletedBook == null) throw new NullReferenceException();
            dbContext.Books.Remove(deletedBook);
            dbContext.SaveChanges();
        }

    }
}
