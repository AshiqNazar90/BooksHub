using BooksHub.Data;
using BooksHub.Models;
using BooksHub.Services.Interface;

namespace BooksHub.Services
{
    public class BookService : IBookService

    {
        BooksHubDbContext dbContext;
        public BookService(BooksHubDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public Book Add(Book book)
        {
            dbContext.Add(book);
            dbContext.SaveChanges();
            return book;
        }

        public Book Delete(int id, Book book)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book Update(int id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
