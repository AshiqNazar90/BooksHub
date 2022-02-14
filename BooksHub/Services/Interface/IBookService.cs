using BooksHub.Models;

namespace BooksHub.Services.Interface
{
    public interface IBookService
    {
        public Book Add(Book book);
        public List <Book> GetAll();

        public Book Get(int id);

        public Book Update(int id,Book book);

        public Book Delete(int id, Book book);



    }
}
