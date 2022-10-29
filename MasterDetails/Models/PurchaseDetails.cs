using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterDetails.Models
{
    public class PurchaseDetails
    {
        public PurchaseDetails()
        {

        }
        [Key]
        public int PurchaseDtlsId { get; set; }
        public string Driscription { get; set; }
        [Required]
        public Decimal Qty { get; set; }
        [Required]
        public Decimal Price { get; set; }
        [Required]
        public Decimal Total { get; set; }
        [ForeignKey("PurchaseInfo")]
        public int PrcuaseId { get; set; }
        public virtual PurchaseInfo PurchaseInfo { get; set; }
    }
}
