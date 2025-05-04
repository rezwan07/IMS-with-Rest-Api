using IMS_with_Rest_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IMS_with_Rest_Api.Controllers
{
    public class CategoryController : ApiController
    {
        InventoryDataContext context = new InventoryDataContext();

        //[HttpGet]
        //public IHttpActionResult AllCategories()
        //{
        //    return Ok(context.Categories.ToList());
        //}

        [Route("api/categories")]
        public IHttpActionResult Get()
        {
            return Ok(context.Categories.ToList());
        }
        [Route("api/categories/{id}")]
        public IHttpActionResult Get(int id)
        {
            Category category = context.Categories.Find(id);
            if (category == null)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Ok(category);
        }
        [Route("api/categories")]
        public IHttpActionResult Post(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return Created("api/categories/"+category.CategoryId, category);
        }

        [Route("api/categories/{id}"), HttpPut]
        public IHttpActionResult Edit([FromBody]Category category,[FromUri] int id)
        {
            category.CategoryId = id;
            context.Entry(category).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return Ok(category);
        }

        [Route("api/categories/{id}"), HttpDelete]
        public IHttpActionResult Remove([FromUri] int id)
        {
            context.Categories.Remove(context.Categories.Find(id));
            context.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
