

using Products.Models;

namespace Products.Services.Items
{
    public interface IItemService
    {

        public Task<List<Item>> GetItems();

        public Task<Item> GetItemById(Guid id);

        public Task<List<Item>> DeleteItem(Guid id);

        public Task<List<Item>> AddItem(Item item);

        public Task<List<Item>> UpdateItem(Item updateitem);


    }
}
