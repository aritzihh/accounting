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

        [Column("opening_balance")]
        public decimal? OpeningBalance { get; set; }

        [Precision(18, 4)]
        [Column("debit")]
        public decimal? Debit { get; set; }

        [Precision(18, 4)]
        [Column("credit")]
        public decimal? Credit { get; set; }

        [Precision(18, 4)]
        [Column("final_balance")]
        public decimal? FinalBalance { get; set; }

        [Required]
        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow.AddHours(-6);

        [Required]
        [Column("accounting_period_id")]
        [ForeignKey(nameof(AccountingPeriod))]
        public int AccountingPeriodId { get; set; }

        
        public virtual AccountingAccount? AccountingAccount { get; set; }
        public virtual AccountingPeriod? AccountingPeriod { get; set; }

    }
}
