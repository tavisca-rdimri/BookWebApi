using DemoApi.Model;
using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace BookTest
{
    public class UnitTest1
    {
        [Fact]
        public void getting_booklist_without_id()
        {
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book { ID = 1, Name = "Web Api", Price = 250, Author = "abc", category = "Programming" });
            bookList.Add(new Book { ID = 2, Name = "Clean Code", Price = 150, Author = "def", category = "Programming" });
            bookList.Add(new Book { ID = 3, Name = "Web Server", Price = 350, Author = "xyz", category = "Programming" });
            BookService bookService = new BookService();
            bookService.Get().Should().BeEquivalentTo(bookList);

        }
       [Fact]
        public void getting_booklist_with_id()
        {
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book { ID = 1, Name = "Web Api", Price = 250, Author = "abc", category = "Programming" });
            bookList.Add(new Book { ID = 2, Name = "Clean Code", Price = 150, Author = "def", category = "Programming" });
            bookList.Add(new Book { ID = 3, Name = "Web Server", Price = 350, Author = "xyz", category = "Programming" });
            BookService bookService = new BookService();
            string output = $"ID: {bookList[0].ID}, Name: {bookList[0].Name}, Author: {bookList[0].Author}, Category:{bookList[0].category}, Price: {bookList[0].Price}";
            Assert.Equal(bookService.GetById(1), output);
        }
        
        [Fact]
        public void Posting_into_a_booklist()
        {
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book { ID = 1, Name = "Web Api", Price = 250, Author = "abc", category = "Programming" });
            bookList.Add(new Book { ID = 2, Name = "Clean Code", Price = 150, Author = "def", category = "Programming" });
            bookList.Add(new Book { ID = 3, Name = "Web Server", Price = 350, Author = "xyz", category = "Programming" });
            BookService bookService = new BookService();

            bookList.Add(new Book { ID = 4, Name = "HTML", Price = 300, Author = "jkl", category = "Programming" });
            bookService.Post(new Book { ID = 4, Name = "HTML", Price = 300, Author = "jkl", category = "Programming" });

            bookService.Get().Should().BeEquivalentTo(bookList);
        }

        [Fact]
        public void deleting_from_the_booklist()
        {
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book { ID = 1, Name = "HTML", Price = 300, Author = "jkl", category = "Programming" });
            bookList.Add(new Book { ID = 2, Name = "Clean Code", Price = 150, Author = "def", category = "Programming" });

            BookService bookService = new BookService();
            bookService.Delete(3);

            bookService.Get().Should().BeEquivalentTo(bookList);
        }
        

        [Fact]
        public void updating_the_booklist()
        {
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book { ID = 1, Name = "HTML", Price = 300, Author = "jkl", category = "Programming" });
            bookList.Add(new Book { ID = 2, Name = "Clean Code", Price = 150, Author = "def", category = "Programming" });
            bookList.Add(new Book { ID = 3, Name = "Web Server", Price = 350, Author = "xyz", category = "Programming" });
            BookService bookService = new BookService();

            bookService.Put(1, new Book { ID = 1, Name = "HTML", Price = 300, Author = "jkl", category = "Programming" });

            bookService.Get().Should().BeEquivalentTo(bookList);
        }

    }
}
