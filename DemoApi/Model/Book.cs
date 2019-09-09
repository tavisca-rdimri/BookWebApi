using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Model
{
    public class Book
    {
        public int ID { get; set; }
        public string category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
    }
}
