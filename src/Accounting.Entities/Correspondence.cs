using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class Correspondence
    {

        [Key]
        [Column("correspondences_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CorrespondencesId { get; set; }

        [Column("fiscal_years_source_id")]
        [ForeignKey(nameof(FiscalYearSource))]
        public int? FiscalYearsSourceId { get; set; }

        [Column("accounting_accounts_source_id")]
        [ForeignKey(nameof(AccountingAccountSource))]
        public int? AccountingAccountsSourceId { get; set; }

        [Column("fiscal_years_destination_id")]
        [ForeignKey(nameof(FiscalYearDestination))]
        public int? FiscalYearsDestinationId { get; set; }

        [Column("accounting_accounts_destination_id")]
        [ForeignKey(nameof(AccountingAccountDestination))]
        public int? AccountingAccountsDestinationId { get; set; }

        [Column("status")]
        [MaxLength(50)]
        public string? Status { get; set; }

        [Column("migration_type")]
        [MaxLength(50)]
        public string? MigrationType { get; set; }

        [Column("reviewed_by_user_id")]
        public int? ReviewedByUserId { get; set; }

        [Column("reviewed_date")]
        public DateTime? ReviewedDate { get; set; }

        [Column("notes")]
        [MaxLength(500)]
        public string? Notes { get; set; }

        [Required]
        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; }

        public virtual FiscalYear? FiscalYearSource { get; set; }
        public virtual AccountingAccount? AccountingAccountSource { get; set; }
        public virtual FiscalYear? FiscalYearDestination { get; set; }
        public virtual AccountingAccount? AccountingAccountDestination { get; set; }

    }
}
