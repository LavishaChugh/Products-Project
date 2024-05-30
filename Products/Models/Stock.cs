namespace Products.Models
{
    public class Stock
    {

        public Guid Id { get; set; }

        public int Quantity { get; set; }

        public Item? Items { get; set; }

        public Puchase? Purchase { get; set; }

    }
}
