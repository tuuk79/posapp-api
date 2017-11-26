using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using server.Data;
using server.Models;

namespace server.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly OrderContext _context;
        public ProductsController(OrderContext context)
        {
            _context = context;
        }

        // GET: api/VehicleLocations
        [HttpGet]
        public IEnumerable<Product> GetOrder()
        {
            return _context.Products.ToList();
        }
    }
}
