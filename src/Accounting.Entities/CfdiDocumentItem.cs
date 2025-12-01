using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class CfdiDocumentItem
    {

        [Key]
        [Column("cfdi_document_item_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CfdiDocumentItemId { get; set; }

        [Required]
        [Column("cfdi_document_id")]
        [ForeignKey(nameof(CfdiDocument))]
        public int CfdiDocumentId { get; set; }

        [Required]
        [Column("product_service_key")]
        [MaxLength(20)]
        public string ProductServiceKey { get; set; } = string.Empty;

        [Required]
        [Column("description")]
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        [Column("unit_key")]
        [MaxLength(20)]
        public string? UnitKey { get; set; }

        [Column("unit")]
        [MaxLength(50)]
        public string? Unit { get; set; }

        [Required]
        [Column("quantity", TypeName = "decimal(18, 4)")]
        public decimal Quantity { get; set; }

        [Required]
        [Column("unit_price", TypeName = "decimal(18, 4)")]
        public decimal UnitPrice { get; set; }

        [Column("discount", TypeName = "decimal(18, 4)")]
        public decimal? Discount { get; set; }

        [Required]
        [Column("subtotal", TypeName = "decimal(18, 4)")]
        public decimal Subtotal { get; set; }

        [Column("tax_transferred", TypeName = "decimal(18, 4)")]
        public decimal? TaxTransferred { get; set; }

        [Column("tax_withheld", TypeName = "decimal(18, 4)")]
        public decimal? TaxWithheld { get; set; }

        [Required]
        [Column("total", TypeName = "decimal(18, 4)")]
        public decimal Total { get; set; }

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; } = true;

        [Required]
        [Column("created_at", TypeName = "datetime2(3)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at", TypeName = "datetime2(3)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }

        // Navigation property
        [DeleteBehavior(DeleteBehavior.Cascade)]
        public virtual CfdiDocument? CfdiDocument { get; set; }

    }
}
