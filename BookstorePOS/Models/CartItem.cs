namespace Bookstore.Models
{
    public class CartItem
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }

        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
    }
}
