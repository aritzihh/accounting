using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class Balance
    {

        [Key]
        [Column("balances_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BalancesId { get; set; }

        [Required]
        [Column("accounting_accounts_id")]
        [ForeignKey(nameof(AccountingAccount))]
        public int AccountingAccountsId { get; set; }

        [Column("opening_balance", TypeName = "decimal(18, 4)")]
        public decimal? OpeningBalance { get; set; }

        [Column("debit", TypeName = "decimal(18, 4)")]
        public decimal? Debit { get; set; }

        [Column("credit", TypeName = "decimal(18, 4)")]
        public decimal? Credit { get; set; }

        [Column("final_balance", TypeName = "decimal(18, 4)")]
        public decimal? FinalBalance { get; set; }

        [Required]
        [Column("created_at", TypeName = "datetime2(3)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at", TypeName = "datetime2(3)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }

        [Required]
        [Column("accounting_period_id")]
        [ForeignKey(nameof(AccountingPeriod))]
        public int AccountingPeriodId { get; set; }

        
        public virtual AccountingAccount? AccountingAccount { get; set; }
        public virtual AccountingPeriod? AccountingPeriod { get; set; }

    }
}
