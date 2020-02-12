using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Model
{
    public interface IBookService
    {
        IEnumerable<Book> Get();

        string GetById(int id);

        string Post(Book value);

        string Put(int id, Book value);
        string Delete(int id);
    }
}
