using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    [Table("diot_transactions")]
    public class DiotTransaction
    {
        [Key]
        [Column("diot_transactions_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DiotTransactionsId { get; set; }

        [Column("diot_concept_id")]
        [Required]
        [ForeignKey(nameof(DiotConcept))]
        public int DiotConceptId { get; set; }

        [Column("diot_operation")]
        public int? DiotOperation { get; set; }

        [Column("policy_id")]
        [Required]
        [ForeignKey(nameof(Policy))]
        public int PolicyId { get; set; }

        [Column("policy_date")]
        [Required]
        public DateTime PolicyDate { get; set; }

        [Column("accounting_account_id")]
        [Required]
        [ForeignKey(nameof(AccountingAccount))]
        public int AccountingAccountId { get; set; }

        [Column("debit", TypeName = "decimal(18, 2)")]
        public decimal? Debit { get; set; }

        [Column("credit", TypeName = "decimal(18, 2)")]
        public decimal? Credit { get; set; }

        [Column("iva_base", TypeName = "decimal(18, 0)")]
        [Required]
        public decimal IvaBase { get; set; }

        [Column("iva_amount", TypeName = "decimal(18, 0)")]
        [Required]
        public decimal IvaAmount { get; set; }

        [Column("iva_cup", TypeName = "decimal(18, 0)")]
        [Required]
        public decimal IvaCup { get; set; }

        [Column("diot_field")]
        [Required]
        public int DiotField { get; set; }

        [Column("cfdi_document_id")]
        [ForeignKey(nameof(CfdiDocument))]
        public int? CfdiDocumentId { get; set; }

        [Column("supplier_id")]
        [ForeignKey(nameof(Supplier))]
        public int? SupplierId { get; set; }

        [Column("created_at")]
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [Column("is_active")]
        [Required]
        public bool IsActive { get; set; } = true;

        public virtual DiotConcept? DiotConcept { get; set; }
        public virtual Policy? Policy { get; set; }
        public virtual AccountingAccount? AccountingAccount { get; set; }
        public virtual CfdiDocument? CfdiDocument { get; set; }
        public virtual Supplier? Supplier { get; set; }
    }
}
