using API2.Data;
using API2.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Controllers
{
    public class ProductsController : BaseApiController
    {
        private readonly StoreContext _storeContext;
        public ProductsController(StoreContext context)
        {
            _storeContext = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts() 
        {
            return await _storeContext.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id) 
        {
            return await _storeContext.Products.FindAsync(id);
        }

    }
}
