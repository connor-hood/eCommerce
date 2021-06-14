using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET
        [HttpGet]
        public IActionResult Get()
        {
            var home = _context;
            return Ok(home);
        }

    }
}
