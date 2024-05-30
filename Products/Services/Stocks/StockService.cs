
namespace Products.Services.Stocks
{
    public class StockService : IStockService
    {
        private readonly DataContext _context;

        public StockService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Stock>> GetStocks()
        {
            var stocks = await _context.stocks.Include(c => c.Items).Include(c => c.Purchase).ToListAsync();
            return stocks;
        }
    }
}
