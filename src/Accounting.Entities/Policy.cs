using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class Policy
    {

        [Key]
        [Column("policy_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PolicyId { get; set; }

        [Required]
        [Column("fiscal_years_id")]
        [ForeignKey(nameof(FiscalYear))]
        public int FiscalYearsId { get; set; }

        [Column("types_policies_id")]
        [ForeignKey(nameof(TypesPolicy))]
        public int? TypesPoliciesId { get; set; }

        [Column("daily_codes_id")]
        [ForeignKey(nameof(DailyCode))]
        public int? DailyCodesId { get; set; }

        [Required]
        [Column("concept")]
        [MaxLength(500)]
        public string Concept { get; set; } = string.Empty;

        [Required]
        [Column("date")]
        public DateTime Date { get; set; }

        [Column("application_date")]
        public DateTime? ApplicationDate { get; set; }

        [Column("desaplication_date")]
        public DateTime? DesaplicationDate { get; set; }

        [Column("supplier_id")]
        [ForeignKey(nameof(Supplier))]
        public int? SupplierId { get; set; }

        [Column("beneficiary_name")]
        [MaxLength(250)]
        public string? BeneficiaryName { get; set; }

        [Column("status")]
        [MaxLength(5)]
        public string? Status { get; set; }

        [Required]
        [Column("number_policy")]
        public int NumberPolicy { get; set; }

        [Required]
        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow.AddHours(-6);

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; }

        public virtual FiscalYear? FiscalYear { get; set; }
        public virtual TypesPolicy? TypesPolicy { get; set; }
        public virtual DailyCode? DailyCode { get; set; }
        public virtual Supplier? Supplier { get; set; }

    }
}
