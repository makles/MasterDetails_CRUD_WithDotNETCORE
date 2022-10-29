using System.ComponentModel.DataAnnotations;

namespace MasterDetails.Models
{
    public class PurchaseInfo
    {
        [Key]
        public int PrcuaseId { get; set; }
        [Required]
        [StringLength(50)]
        public string? OrderNo { get; set; }
        [Required]
        [StringLength(50)]
        public string ? PONO { get; set; }
        [Required]
        [StringLength(100)]
        public string? Address { get; set; }
        [Required]
        public string ProdctId { get; set; }

        public virtual List<PurchaseDetails> PurchaseDetails { get; set; } = new List<PurchaseDetails>();

    }
}
