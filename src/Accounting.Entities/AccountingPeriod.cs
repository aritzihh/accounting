using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class AccountingPeriod
    {

        [Key]
        [Column("accounting_period_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountingPeriodId { get; set; }

        [Required]
        [Column("fiscal_years_id")]
        [ForeignKey(nameof(FiscalYear))]
        public int FiscalYearsId { get; set; }

        [Required]
        [Column("period_number")]
        public int PeriodNumber { get; set; }

        [Required]
        [Column("is_closed")]
        public bool IsClosed { get; set; }

        [Column("closing_date", TypeName = "datetime2(3)")]
        public DateTime? ClosingDate { get; set; }

        [Column("closed_by_user_id")]
        public int? ClosedByUserId { get; set; }

        [Column("notes")]
        [MaxLength(500)]
        public string? Notes { get; set; }

        [Required]
        [Column("created_at", TypeName = "datetime2(3)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at", TypeName = "datetime2(3)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; }

        public virtual FiscalYear? FiscalYear { get; set; }

    }
}
