﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Model
{
    public class BookService : IBookService
    {
        Validator validator = new Validator();
        static BookData bookData = new BookData();
        public IEnumerable<Book> Get()
        {
            return bookData.Get();
        }

        public string GetById(int id)
        {
            if (id >= 0)
            {
                Book book = new Book();
                book = bookData.GetById(id);
                if (book != null)
                {
                    return $"ID: {book.ID}, Name: {book.Name}, Author: {book.Author}, Category:{book.category}, Price: {book.Price}";
                }
                return "Not Found";
            }
            return "ID can't be a negative number";
        }
        public string Post(Book value)
        {
            if (!Validator.IsValidBook(value, out string error))
            {
                throw new BadRequestException(error);
            }

            if (bookData.Post(value) == null)
                return "Value cannot be null";
            return $"Successful\n ID: {value.ID}, Name:{value.Name}, Author: {value.Author}, Category:{value.category}, Price: {value.Price}";
        }

        public string Put(int id,Book value)
        {
            if (bookData.Put(id, value) == null)
                return "Cannot Find the book";
            return $"Update successful ID: {value.ID}, Name:{value.Name}, Author: {value.Author}, Category:{value.category}, Price: {value.Price}";
        }

        public string Delete(int id)
        {
            return bookData.Delete(id);
        }
    }
}
