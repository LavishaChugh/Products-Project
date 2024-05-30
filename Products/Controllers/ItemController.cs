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


        //GetAll Items
        [HttpGet("GetAll/Items")]
        public async Task<ActionResult<List<Item>>> GetAllItems()
        {
            var items = await _itemService.GetItems();
            return Ok(items);
        }


        //Get-Item by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItemById(Guid id)
        {
         
            var item = await _itemService.GetItemById(id);
            return Ok(item);
        }

        //Delete-Item
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Item>>> DeleteItem(Guid id)
        {
            var items = await _itemService.DeleteItem(id);
            return Ok(items);
        }

        //Post-Item
        [HttpPost]
        public async Task<ActionResult<List<Item>>> AddItem(Item item)
        {
            var items = await _itemService.AddItem(item);
            return Ok(items);
        }

        //Update-Item
        [HttpPut]
        public async Task<ActionResult<List<Item>>> UpdateItem(Item item)
        {
            var items = await _itemService.UpdateItem(item);
            return Ok(items);
        }

    }
}
