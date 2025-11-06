namespace JooneliTrading.Models
{
    public class ProductPricing
    {
        public string Title { get; set; } = string.Empty;

        public string Price { get; set; } = string.Empty;

        public string YearlyPrice { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public List<string> Properties { get; set; } = new();

        public List<string> NotProperties { get; set; } = new();
    }
}
