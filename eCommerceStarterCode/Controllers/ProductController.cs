using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Mvc;


namespace eCommerceStarterCode.Controllers
{
    //missing await/async in these files?
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private Data.ApplicationDbContext _context;

        public ProductController(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _context.Products;
            return Ok(products);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product value)
        {
            _context.Products.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _context.Products.Where(p => p.ProductId == id).SingleOrDefault();

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {

            //loops through products and nabs a specific one to be deleted
            foreach (var p in _context.Products.Where(product => product.ProductId == id).ToArray()) _context.Products.Remove(p);
            _context.SaveChanges();

            //var product = _context.Products.Where(p => p.ProductId == id).FirstOrDefault();
            //_context.Products.Remove(product);

            return StatusCode(204);
        }

        // TODO: needs a put request
    }
}
