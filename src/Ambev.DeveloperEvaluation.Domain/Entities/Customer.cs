using Ambev.DeveloperEvaluation.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{

    public class Customer : BaseEntity
    {
        [StringLength(3,ErrorMessage ="Code must be between 3 and 50")]
        public string CustomerCodeId { get; set; } = string.Empty;

        [StringLength(150, ErrorMessage = "{0} must be between 3 and 50",MinimumLength = 3)]
        public string CustomerName { get; set; } = string.Empty;
        
        public string CustomerPhone { get; set; } = string.Empty;

        [EmailAddress]
        public string CustomerEmail { get; set; } = string.Empty;

        [StringLength(150, ErrorMessage = "{0} must be between 3 and 150", MinimumLength = 3)]
        public string CustomerCity { get; set; } = string.Empty;

        [StringLength(2, ErrorMessage = "{0} have to be 2 characteres")]
        public string CustomerState { get; set; } = string.Empty;

        [StringLength(150, ErrorMessage = "{0} must be between 3 and 150", MinimumLength = 3)]
        public string CustomerCountry { get; set; } = string.Empty;

        [StringLength(150, ErrorMessage = "{0} must be between 3 and 150", MinimumLength = 3)]
        public string CustommerAddress {  get; set; } = string.Empty;
    }
}