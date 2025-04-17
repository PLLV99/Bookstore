namespace Bookstore.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentMethod { get; set; }

        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
    }
}
