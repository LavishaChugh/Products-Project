using Products.Migrations;
using Products.Models;

namespace Products.Services.Purchase
{
    public class PurchaseService : IPurchaseService
    {
        private readonly DataContext _context;

        public PurchaseService(DataContext context)
        {
            _context = context;
        }


        //delete
        public async Task<List<Puchase>> Delete(Guid id)
        {
            var result = await _context.Puchases.FirstOrDefaultAsync(p => p.Id == id);

            if (result is null || result.Id != id)
            {
                throw new Exception("ID NOT FOUND");
            }

            _context.Puchases.Remove(result);
            await _context.SaveChangesAsync();

            var purchases = await _context.Puchases.Include(p => p.Item).ToListAsync();

            return purchases;
            
        }

        //getall
        public async Task<List<Puchase>> GetAll()
        {
            var result = await _context.Puchases.Include(p => p.Item).ToListAsync();
            //return await _context.Puchases.ToListAsync();
            return result;
        }

        //getbyid
        public async Task<Puchase> GetById(Guid id)
        { 
            var result = await _context.Puchases.Include(p => p.Item).FirstOrDefaultAsync(Item => Item.Id == id);

            if (result is null || result.Id != id)
            {
                throw new Exception("ID NOT FOUND");
            }

            return result;
        }
    }
}
