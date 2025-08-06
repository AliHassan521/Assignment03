namespace Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public List<Product> Products { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsPaid { get; set; }

        public Order()
        {
            OrderId = Guid.NewGuid().ToString();
            Products = new List<Product>();
            OrderDate = DateTime.Now;
            IsPaid = false;
        }

        public decimal GetTotalAmount()
        {
            decimal total = 0;
            foreach (var p in Products)
            {
                total += p.Price;
            }
            return total;
        }
    }
}
