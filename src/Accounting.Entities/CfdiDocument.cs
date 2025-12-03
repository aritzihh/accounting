using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Entities
{
    public class CfdiDocument
    {

        [Key]
        [Column("cfdi_document_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CfdiDocumentId { get; set; }

        [Required]
        [Column("uuid")]
        [MaxLength(36)]
        public string Uuid { get; set; } = string.Empty;

        [Column("version")]
        [MaxLength(10)]
        public string? Version { get; set; }

        [Required]
        [Column("document_type_id")]
        [ForeignKey(nameof(DocumentType))]
        public int DocumentTypeId { get; set; }

        [Column("sat_currency_id")]
        [ForeignKey(nameof(SatCurrency))]
        public int? SatCurrencyId { get; set; }

        [Column("payment_method_id")]
        [ForeignKey(nameof(SatPaymentMethod))]
        public int? SatPaymentMethodId { get; set; }

        [Column("payment_way_id")]
        [ForeignKey(nameof(SatPaymentWay))]
        public int? SatPaymentWayId { get; set; }

        [Column("cfdi_status_id")]
        [ForeignKey(nameof(SatCfdiStatus))]
        public int? SatCfdiStatusId { get; set; }

        [Required]
        [Column("issue_date")]
        public DateTime IssueDate { get; set; }

        [Column("certification_date")]
        public DateTime? CertificationDate { get; set; }

        [Required]
        [Column("exchange_rate")]
        [Precision(18, 6)]
        public decimal ExchangeRate { get; set; }

        [Required]
        [Column("emitter_rfc")]
        [MaxLength(13)]
        public string EmitterRfc { get; set; } = string.Empty;

        [Required]
        [Column("emitter_name")]
        [MaxLength(255)]
        public string EmitterName { get; set; } = string.Empty;

        [Required]
        [Column("receiver_rfc")]
        [MaxLength(13)]
        public string ReceiverRfc { get; set; } = string.Empty;

        [Required]
        [Column("receiver_name")]
        [MaxLength(255)]
        public string ReceiverName { get; set; } = string.Empty;

        [Required]
        [Column("subtotal")]
        [Precision(18, 2)]
        public decimal Subtotal { get; set; }

        [Column("discount")]
        [Precision(18, 2)]
        public decimal? Discount { get; set; }

        [Column("tax_transferred")]
        [Precision(18, 2)]
        public decimal? TaxTransferred { get; set; }

        [Column("tax_withheld")]
        [Precision(18, 2)]
        public decimal? TaxWithheld { get; set; }

        [Required]
        [Column("total")]
        [Precision(18, 2)]
        public decimal Total { get; set; }

        [Column("related_uuid")]
        [MaxLength(36)]
        public string? RelatedUuid { get; set; }

        [Column("link_status_id")]
        public int? LinkStatusId { get; set; }

        [Column("xml_path")]
        [MaxLength(500)]
        public string? XmlPath { get; set; }

        [Column("pdf_path")]
        [MaxLength(500)]
        public string? PdfPath { get; set; }

        [Column("link_date")]
        public DateTime? LinkDate { get; set; }

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; }

        [Required]
        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow.AddHours(-6);

        [Required]
        [Column("policy_id")]
        [ForeignKey(nameof(Policy))]
        public int PolicyId { get; set; }

        // Navigation properties
        public virtual SatDocumentType? DocumentType { get; set; }
        public virtual SatCurrency? SatCurrency { get; set; }
        public virtual SatPaymentMethod? SatPaymentMethod { get; set; }
        public virtual SatPaymentWay? SatPaymentWay { get; set; }
        public virtual SatCfdiStatus? SatCfdiStatus { get; set; }
        public virtual Policy? Policy { get; set; }

    }
}
