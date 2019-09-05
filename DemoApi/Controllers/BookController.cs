using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        static BookService bookService = new BookService();
        // GET: api/book
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return bookService.Get();
        }

        // GET: api/book/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return bookService.GetById(id);
        }

        // POST: api/book
        [HttpPost]
        public string Post([FromBody] Book value)
        {
           return bookService.Post(value);
        }

        // PUT: api/book/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Book value)
        {
            return bookService.Put(id,value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return bookService.Delete(id);
        }
    }
}
