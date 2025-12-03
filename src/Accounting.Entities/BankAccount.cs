
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
        public int BankAccountId { get; set; }

        [Column("accounting_accounts_id")]
        public int AccountingAccountsId { get; set; }

        [Column("bank_id")]
        public int BankId { get; set; }

        [MaxLength(30)]
        [Column("account_number")]
        public string AccountNumber { get; set; } = string.Empty;

        [MaxLength(20)]
        [Column("clabe")]
        public int Clabe {  get; set; }

        [Column("sat_currency_id")]
        public int SatCurrencyId { get; set; }

        [MaxLength(100)]
        [Column("branch_name")]
        public string BranchName { get; set; } = string.Empty;

        [Precision(18, 2)]
        [Column("initial_balance")]
        public decimal InitialBalance { get; set; }

        [Column("is_active")]
        [Required]
        public bool IsActive { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow.AddHours(-6);
    }
}
