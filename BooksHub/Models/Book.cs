using System.ComponentModel.DataAnnotations;

namespace BooksHub.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }
       
    }
}
