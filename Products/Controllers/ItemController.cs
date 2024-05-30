using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Models;
using Products.Services.Items;

namespace Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService) 
        {
            _itemService = itemService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Item>>> Get()
        {
            var items = await _itemService.GetItems();
            return Ok(items);
        }


    }
}
