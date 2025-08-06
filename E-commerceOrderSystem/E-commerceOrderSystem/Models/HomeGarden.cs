using Enums;

namespace Models
{
    public class HomeGarden : Product
    {
        public string Usage { get; set; }

        public override string GetProductDetails()
        {
            return "[Home & Garden] " + Name + " | Usage: " + Usage + " | Price: " + Price;
        }
    }
}
