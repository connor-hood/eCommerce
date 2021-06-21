using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceStarterCode.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private Data.ApplicationDbContext _context;

        public ShoppingCartController(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        // Get All Items For User
        [HttpGet("{userId}")]
        public IActionResult Get(string userId)
        {
            var items = _context.ShoppingCarts.Include(i => i.Product).Include(i => i.User).Where(i => i.UserId == userId).ToList();

            return StatusCode(200, items);
        }

        // Add Item
        [HttpPost("{userId}")]
        public IActionResult Post(string userId, [FromBody] ShoppingCart value)
        {
            value.UserId = userId;
            _context.ShoppingCarts.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        // Delete Item
        [HttpDelete("{userId}/{productId}")]
        public IActionResult Delete(string userId, int productId)
        {
            try
            {
                var item = _context.ShoppingCarts.Where(i => i.UserId == userId && i.ProductId == productId).SingleOrDefault();
                _context.ShoppingCarts.Remove(item);
                _context.SaveChanges();
                return StatusCode(204);
            } catch {
                return StatusCode(404);
            }  
        }

        // Update Item Quantity
        [HttpPut("{userId}/{productId}")]
        public IActionResult Put(string userId, int productId, [FromBody] ShoppingCart value)
        {
            try
            {
                var item = _context.ShoppingCarts.Where(i => i.UserId == userId && i.ProductId == productId).SingleOrDefault();
                item.Quantity = value.Quantity;
                _context.SaveChanges();
                return StatusCode(200, item);
            }
            catch
            {
                return StatusCode(404);
            }
        }
    }
}
