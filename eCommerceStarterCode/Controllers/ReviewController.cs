﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    { 
        private Data.ApplicationDbContext _context;

        public ReviewController(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var reviews = _context.Reviews;
            return Ok(reviews);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Review value)
        {
            _context.Reviews.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var Review = _context.Reviews.Where(r => r.ReviewId == id).SingleOrDefault();

            return Ok(Review);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {

            //loops through products and nabs a specific one to be deleted
            foreach (var r in _context.Reviews.Where(r => r.ReviewId == id).ToArray()) _context.Reviews.Remove(r);
            _context.SaveChanges();

            return StatusCode(204);
        }
       
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Review value)
        {
            var Review = _context.Reviews.Where(r => r.ReviewId == id).SingleOrDefault();
            Review.Rating = value.Rating;
            Review.Text = value.Text;
            Review.ProductId = value.ProductId;
            Review.Product = value.Product;
            Review.UserId = value.UserId;
            Review.User = value.User;

            _context.SaveChanges();

            return Ok(Review);
        }


    }
    // TODO: needs getbyid/put/delete
}