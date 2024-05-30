namespace Products.Models
{
    public class Item
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Price { get; set; } 
    }
}
