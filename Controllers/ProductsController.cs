using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using server.Data;
using server.Repos;
using server.Models;
using Microsoft.EntityFrameworkCore;

namespace server.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        IProductRepo _productRepo;
        public ProductsController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        //[HttpGet("{id}")]
        //public JsonResult Get(int id)
        //{
        //    return Json("product1");
        //}

        //[HttpGet]
        //public IEnumerable<T> Get()
        //{
        //    return Json("product1");
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody]Product product)
        {
            var status = await _productRepo.Update(product);
           
            return Ok("true");
        }

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
