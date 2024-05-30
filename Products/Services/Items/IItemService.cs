

using Products.Models;

namespace Products.Services.Items
{
    public interface IItemService
    {

        public Task<List<Item>> GetItems();

    }
}
