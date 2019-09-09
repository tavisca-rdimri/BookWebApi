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
        public ActionResult Get()
        { 

            try
            {
                return Ok(bookService.Get());
            }
            catch (BadRequestException exception)
            {
                return BadRequest(new Error(exception.Message));
            }
        }

        // GET: api/book/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            try
            {
                return Ok(bookService.GetById(id));
            }
            catch (BadRequestException exception)
            {
                return BadRequest(new Error(exception.Message));
            }
        }

        // POST: api/book
        [HttpPost]
        public ActionResult Post([FromBody] Book value)
        {
            try
            {
                return Ok(bookService.Post(value));
            }
            catch (BadRequestException exception)
            {
                return BadRequest(new Error(exception.Message));
            }
        }

        // PUT: api/book/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Book value)
        {
            try
            {
                return Ok(bookService.Put(id, value));
            }
            catch (BadRequestException exception)
            {
                return BadRequest(new Error(exception.Message));
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                return Ok(bookService.Delete(id));
            }
            catch (BadRequestException exception)
            {
                return BadRequest(new Error(exception.Message));
            }
        }
    }
}
