
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Entities
{
    public class AccountingAccount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("accounting_account_id")]
        public int accountingAccountId { get; set; }

        [Column("fiscal_years_accounting_accounts_setup_id")]
        public int fiscalYearsAccountingAccountsSetupId { get; set; }

        [Column("sat_codes_id")]
        public int satCodesId { get; set; }

        [MaxLength(100)]
        [Column("accounting_account_key")]
        public string accountingAccountKey { get; set; }

        [MaxLength(200)]
        [Column("name")]
        public string name { get; set; }

        [Column("sat_currency_id")]
        public int satCurrencyId { get; set; }

        [Column("nature_id")]
        public int natureId { get; set; }

        [Column("parent_accounting_account_id")]
        public int parentAccountingAccountId { get; set; }

        [Column("is_detail")]
        public bool isDetail { get; set; }

        [Column("created_at")]
        public DateTime createdAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime updatedAt { get; set; }

        [Column("is_active")]
        public bool isActive { get; set; }

        [ForeignKey(nameof(accountingAccountId))]
        public virtual AccountingAccount AccountingAccountsFK { get; set; }

        [ForeignKey(nameof(satCurrencyId))]
        public virtual SatCurrency SatCurrencies { get; set; }

        [ForeignKey(nameof(natureId))]
        public virtual Nature { get; set;}

        [ForeignKey(nameof(satCodesId))]
        public virtual SatCode SatCodes {  get; set; }

        [ForeignKey(nameof(fiscalYearsAccountingAccountsSetupId))]
        public virtual FiscalYearsAccountingAccountsSetup FiscalYearsAccountingAccountsSetup { get; set;}

        
    }
}
