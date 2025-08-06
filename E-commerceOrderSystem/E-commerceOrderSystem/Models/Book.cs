using Enums;

namespace Models
{
    public class Book : Product
    {
        public string ISBN { get; set; }
        public string Author { get; set; }

        public override string GetProductDetails()
        {
            return "[Book] " + Name + " | Author: " + Author + " | ISBN: " + ISBN + " | Price: " + Price;
        }
    }
}
