using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IGenericRepo<Product> repo;

        public ProductController(IGenericRepo<Product> repo)
        {
            this.repo = repo;
        }

        [HttpPost]
        public async Task<IEnumerable<string>> Create(IEnumerable<Product> products)
            => await repo.Index(products);

        [HttpGet]
        public async Task<Product> Read(string id)
            => await repo.Get(id);

        [HttpPut]
        public async Task<bool> Update(Product product, string id)
            => await repo.Update(product, id);

        [HttpDelete]
        public async Task<bool> Delete(string id)
            => await repo.Delete(id);
    }
}