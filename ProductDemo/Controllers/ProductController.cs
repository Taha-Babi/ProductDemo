using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductDemo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        ProductDBContext ProductDBContext = new ProductDBContext();
        [HttpGet("GetProduct")]
        public Product GetProduct(int id) 
        {
           return ProductDBContext.Products.Include("productVariants").Where(x=> x.Id == id).FirstOrDefault();
        }

        [HttpPost("CreateProduct")]
        public ActionResult CreateProduct([ModelBinder]Product product)
        {
            if (product.productVariants.Count<=0 || product.productVariants.Count > 4)
            {
                return StatusCode(500, "Product Variants counts must be 4 or less and bigger than 0");
            }
           ProductDBContext.Products.Add(product);
           ProductDBContext.SaveChanges();
           return Ok();
        }
        [HttpDelete("DeleteProduct")]
        public ActionResult DeleteProduct(int id)
        {
            var product = ProductDBContext.Products.Find(id);
            if (product == null)
            {
                return StatusCode(500, string.Format("cannot find a product with the id {0}",id));
            }
            ProductDBContext.Products.Remove(product);
            ProductDBContext.SaveChanges();
            return Ok();
        }

        [HttpPost("EditProduct")]
        public ActionResult EditProduct([ModelBinder] Product product)
        {
            if (product.productVariants.Count <= 0 || product.productVariants.Count > 4)
            {
                return StatusCode(500, "Product Variants counts must be 4 or less and bigger than 0");
            }

            //var curProd = ProductDBContext.Products
            //           .Include(x => x.productVariants)
            //           .Single(c => c.Id == product.Id);

            ProductDBContext.Entry(product).State = EntityState.Modified;
            foreach (var item in product.productVariants)
            {
                ProductDBContext.Entry(item).State = EntityState.Modified;
            }
            //ProductDBContext.Entry(curProd.productVariants).CurrentValues.SetValues(product.productVariants);
            ProductDBContext.SaveChanges();
            return Ok();
        }
        [HttpGet("GetProducts/{page}/{limit}")]
        public List<Product> GetProducts(int page, int limit)
        {
            if (page == 0)
                page = 1;

            if (limit == 0)
                limit = int.MaxValue;

            var skip = (page - 1) * limit;

            return ProductDBContext.Products.Include("productVariants").Skip(skip).Take(limit).ToList();
        }

    }
}
