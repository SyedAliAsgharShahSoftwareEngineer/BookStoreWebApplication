using Axtract.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Axtract.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title , string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();

        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>
            {
                new BookModel(){Id=1, Title="MVC", Author="Ali"},
                new BookModel(){Id=2, Title="C#", Author="Asghar"},
                new BookModel(){Id=3, Title="Java", Author="Hamid"},
                new BookModel(){Id=4, Title="PHP", Author="Ahmed"},
                new BookModel(){Id=5, Title="VB", Author="Zainab"},
                new BookModel(){Id=6, Title="Python", Author="Sadia"},
                new BookModel(){Id=7, Title="OOP", Author="Nighat"},
                new BookModel(){Id=8, Title="C++", Author="Ali"},
            };
        }
    }
}
