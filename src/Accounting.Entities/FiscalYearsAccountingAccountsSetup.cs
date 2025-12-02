using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class FiscalYearsAccountingAccountsSetup
    {

        [Key]
        [Column("fiscal_years_accounting_accounts_setup_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FiscalYearsAccountingAccountsSetupId { get; set; }

        [Required]
        [Column("accounting_accounts_setup_id")]
        [ForeignKey(nameof(AccountingAccountsSetup))]
        public int AccountingAccountsSetupId { get; set; }

        [Required]
        [Column("fiscal_years_id")]
        [ForeignKey(nameof(FiscalYear))]
        public int FiscalYearsId { get; set; }

        [Required]
        [Column("is_transfer")]
        public bool IsTransfer { get; set; }

        [Required]
        [Column("created_at", TypeName = "datetime2(3)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Column("updated_at", TypeName = "datetime2(3)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; }

        // Navigation properties
        public virtual AccountingAccountsSetup? AccountingAccountsSetup { get; set; }
        public virtual FiscalYear? FiscalYear { get; set; }

    }
}
