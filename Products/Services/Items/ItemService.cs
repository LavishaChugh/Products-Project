using Microsoft.EntityFrameworkCore;
using Products.Data;
using Products.Models;

namespace Products.Services.Items
{
    public class ItemService : IItemService
    {
        private readonly DataContext _context;

        public ItemService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Item>> GetItems()
        {
            return await _context.Items.ToListAsync();
        }
    }
}
