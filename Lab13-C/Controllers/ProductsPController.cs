using Lab13_C.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab13_C.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsPController : ControllerBase
    {
        private readonly InvoiceContext _context;

        public ProductsPController(InvoiceContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void Insert(Product product)
        {
            Product product1 = new Product();
            product.Name = product1.Name;
            product.Price = product1.Price;
            product.IsDeleted = true;

            _context.Products.Add(product1);
            _context.SaveChanges();
        }
    }
}
