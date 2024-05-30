namespace Products.Services.Stocks
{
    public interface IStockService
    {
        public Task<List<Stock>> GetStocks();
    }
}
