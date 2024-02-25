
namespace AuthAPIModels
{
    public class ShoppingCart
    {
        public int id_ { get; set; }
        public string User { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}