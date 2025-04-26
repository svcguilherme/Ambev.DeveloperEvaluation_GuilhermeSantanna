using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Purchase : BaseEntity
    {
        public  string BranchName { get; private set; } = string.Empty; 
        public string PurchaseCode { get; private set; } = string.Empty;
        public Customer Customer { get; set; }
        public DateOnly PurchaseDate { get; set; } = new DateOnly();
        public decimal TotalPurchase { get; set; }
        public decimal TotalDiscount { get; set; }
        public List<PurchaseItem> PurchaseItems { get; set; }
        public PurchaseStatus PurchaseStatus { get; set; }

    }
}
