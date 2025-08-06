using Enums;

namespace Models
{
    public class Clothing : Product
    {
        public string Size { get; set; }
        public string Material { get; set; }

        public override string GetProductDetails()
        {
            return "[Clothing] " + Name + " | Size: " + Size + " | Material: " + Material + " | Price: " + Price;
        }
    }
}

