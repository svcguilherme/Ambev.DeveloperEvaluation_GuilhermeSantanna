using Ambev.DeveloperEvaluation.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Product : BaseEntity
    {
        [StringLength(50, ErrorMessage = "{0} must be between 3 and 150", MinimumLength = 3)]
        public string CodeProduct { get; set; } = string.Empty;

        [StringLength(150, ErrorMessage = "{0} must be between 3 and 150", MinimumLength = 3)]
        public string ProductName { get; set; } = string.Empty;

        [StringLength(30, ErrorMessage = "{0} must be between 9 and 30", MinimumLength = 9)]
        public string CodeBar { get; set; }

        [StringLength(150, ErrorMessage = "{0} must be between 3 and 150", MinimumLength = 3)]
        public string Description { get; set; } = string.Empty;

        public decimal Price {  get; set; } 

    }
}