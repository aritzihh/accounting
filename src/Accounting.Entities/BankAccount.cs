
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Entities
{
    public class BankAccount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("bank_account_id")]
        public int bankAccountId { get; set; }

        [Column("accounting_accounts_id")]
        public int accountingAccountsId { get; set; }

        [Column("bank_id")]
        public int bankId { get; set; }

        [MaxLength(30)]
        [Column("account_number")]
        public string accountNumber { get; set; }

        [MaxLength(20)]
        [Column("clabe")]
        public int clabe {  get; set; }

        [Column("sat_currency_id")]
        public int satCurrencyId { get; set; }

        [MaxLength(100)]
        [Column("branch_name")]
        public string branchName { get; set; }

        [Precision(18, 2)]
        [Column("initial_balance")]
        public decimal initialBalance { get; set; }

        [Column("is_active")]
        public bool isActive { get; set; }

        [Column("created_at")]
        public DateTime createdAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime updatedAt { get; set; }
    }
}
