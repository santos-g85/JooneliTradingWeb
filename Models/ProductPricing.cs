namespace JooneliTrading.Models
{
    public class ProductPricing
    {
        public string Title { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;

        public List<string> Properties { get; set; } = new();
    }
}
