using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class PolicyDetail
    {

        [Key]
        [Column("policy_detail_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PolicyDetailId { get; set; }

        [Required]
        [Column("policy_id")]
        [ForeignKey(nameof(Policy))]
        public int PolicyId { get; set; }

        [Required]
        [Column("accounting_account_id")]
        [ForeignKey(nameof(AccountingAccount))]
        public int AccountingAccountId { get; set; }

        [Column("exchange_rate", TypeName = "decimal(18, 6)")]
        public decimal? ExchangeRate { get; set; }

        [Column("debit", TypeName = "decimal(18, 2)")]
        public decimal? Debit { get; set; }

        [Column("credit", TypeName = "decimal(18, 2)")]
        public decimal? Credit { get; set; }

        [Column("cfdi_document_id")]
        [ForeignKey(nameof(CfdiDocument))]
        public int? CfdiDocumentId { get; set; }

        [Required]
        [Column("concept")]
        [MaxLength(500)]
        public string Concept { get; set; } = string.Empty;

        [Column("supplier_id")]
        [ForeignKey(nameof(Supplier))]
        public int? SupplierId { get; set; }

        [Required]
        [Column("created_at", TypeName = "datetime2(3)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at", TypeName = "datetime2(3)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; } = true;

        // Navigation properties
        public virtual Policy? Policy { get; set; }
        public virtual AccountingAccount? AccountingAccount { get; set; }
        public virtual CfdiDocument? CfdiDocument { get; set; }
        public virtual Supplier? Supplier { get; set; }

    }
}
