using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Services.Stocks;

namespace Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Stock>>> GetAllStocks()
        {
            var result = await _stockService.GetStocks();
            return Ok(result);
        }

    }
}
