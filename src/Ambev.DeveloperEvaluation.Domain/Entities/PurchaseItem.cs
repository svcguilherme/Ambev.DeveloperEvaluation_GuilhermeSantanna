using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class PurchaseItem : BaseEntity
    {
        public Product Product { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public int TotalDiscount {  get; set; }
        private void setTotalPrice()
        {
            TotalPrice = (Quantity * UnitPrice);
        }

    }
}
