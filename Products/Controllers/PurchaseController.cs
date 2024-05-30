using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Models;
using Products.Services.Purchase;

namespace Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseService _purchaseService;

        public PurchaseController(IPurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }


        //GETALL
        [HttpGet]
        public async Task<ActionResult<List<Puchase>>> GetAll()
        {
            var purchases = await _purchaseService.GetAll();      
            return Ok(purchases);
        }

        //GETBYID
        [HttpGet("{id}")]
        public async Task<ActionResult<Puchase>> GetById(Guid id)
        {
            var result = await _purchaseService.GetById(id);
            return Ok(result);
        }

        //DELETE
        [HttpDelete]
        public async Task<ActionResult<List<Puchase>>> Delete(Guid id)
        {
            var result = await _purchaseService.Delete(id);
            return Ok(result);
        }

    }
}
