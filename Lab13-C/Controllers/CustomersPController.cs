using Lab13_C.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab13_C.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersPController : ControllerBase
    {
        private readonly InvoiceContext _context;
        public CustomersPController(InvoiceContext context)
        {
            _context = context;
        }

        [HttpPost]
        public List<Customer> GetInvoicesByFilter([FromBody] Customer filter)
        {
            var response = _context.Customers
                .Where(x => (x.FirstName == filter.FirstName)
                         && (x.LastName == filter.LastName))
                .OrderByDescending(x => x.LastName)
                .ToList();

            return response;
        }
    }
}
