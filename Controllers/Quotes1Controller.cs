using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuotesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Quotes1Controller : ControllerBase
    {
        static List<Quote> _quote = new List<Quote>()
        {
            new Quote(){Id=0, Author="Brian Tracy", Description="Financial stability", Title="Money"},
            new Quote(){Id=1, Author="Joel Osteen", Description="Your relationship", Title="Covenant"}
        };

        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return _quote;
        }

        [HttpPost]
        public void Post([FromBody]Quote quote)
        {
            _quote.Add(quote);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Quote quote)
        {
            _quote[id] = quote;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _quote.RemoveAt(id);
        }
    }
}
