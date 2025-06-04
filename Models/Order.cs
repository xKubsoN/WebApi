namespace WebApi.Models
{
    public class Order
    {
        public int orderID { get; set; }
        public DateTime orderDate { get; set; }

        public List<int> productIDs { get; set; } = new();
    }
}