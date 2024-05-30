
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

        public async Task<List<Item>> AddItem(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
            var items = await _context.Items.ToListAsync();
            return items;
        }


        //DeleteItem
        public async Task<List<Item>> DeleteItem(Guid id)
        {
            var item = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);

            if (item is null || item.Id != id)
            {
                throw new Exception("ID NOT FOUND!");
            }

            _context.Items.Remove(item);

            _context.SaveChanges();

            return await _context.Items.ToListAsync();

        }


        //GET-BY-ID
        public async Task<Item> GetItemById(Guid id)
        {

            var item = await _context.Items.FirstOrDefaultAsync(c => c.Id == id);

            if (item is null || item.Id != id)
            {
                throw new Exception("ID NOT FOUND");
            }

            return item;
        }


        //GET-ALL
        public async Task<List<Item>> GetItems()
        {
            return await _context.Items.ToListAsync();
        }

        //UPDATE
        public async Task<List<Item>> UpdateItem(Item updateitem)
        {
            
            var item = await _context.Items.FirstOrDefaultAsync(x => x.Id == updateitem.Id);

            if (updateitem is null)
            {
                throw new Exception("ID NOT FOUND!");
            }

            item.Name = updateitem.Name;
            item.Price = updateitem.Price;

            await _context.SaveChangesAsync();

            var items = await _context.Items.ToListAsync();
            return items;

        }
    }
}
