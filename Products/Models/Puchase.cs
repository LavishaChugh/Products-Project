namespace Products.Models
{
    public class Puchase
    {

        public  Guid Id { get; set; }

        public string Date { get; set; } = string.Empty;

        public int Qunatity { get; set; }

        public float TotalCost { get; set; }

        public Item? Item { get; set; }

    }
}
