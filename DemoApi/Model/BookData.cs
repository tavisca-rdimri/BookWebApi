using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Model
{
    public class BookData
    {
        static List<Book> bookList = new List<Book>();
        public BookData()
        {
            bookList.Add(new Book { ID = 1,Name = "Web Api", Price = 250, Author = "abc",category="Programming" });
            bookList.Add(new Book { ID = 2,Name = "Clean Code", Price = 150, Author = "def", category = "Programming" });
            bookList.Add(new Book { ID = 3, Name = "Web Server", Price = 350, Author = "xyz", category = "Programming" });
        }

        
        public IEnumerable<Book> Get()
        {
            return bookList;
        }

        public Book GetById(int id)
        {
            for (int i = 0; i < bookList.Count; i++)
                if (id == bookList[i].ID)
                    return bookList[i];
            return null;
        }
        public List<Book> Post(Book value)
        {
            if (value != null)
            {
                bookList.Add(value);
                return bookList;
            }
            return null;
        }

        public List<Book> Put(int id,Book value)
        {
            for(int i=0;i<bookList.Count;i++)
            {
                if(id==bookList[i].ID)
                {
                    bookList[i] = value;
                    return bookList;
                }
            }
            return null;
        }
        public string Delete(int id)
        {
            for(int i=0;i<bookList.Count;i++)
            {
                if(id==bookList[i].ID)
                {
                    bookList.Remove(bookList[i]);
                    return "Deleted";
                }
            }
            return "Error: Can't Delete the book";
        }

    }



}

