using Enums;

namespace Models
{
    public class Electronics : Product
    {
        public int Warranty { get; set; }

        public override string GetProductDetails()
        {
            return "[Electronics] " + Name + " | Price: " + Price + " | Warranty: " + Warranty + " months";
        }
    }
}
