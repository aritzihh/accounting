
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Entities
{
    public class AccountingAccount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("accounting_account_id")]
        public int AccountingAccountId { get; set; }

        [Column("fiscal_years_accounting_accounts_setup_id")]
        public int FiscalYearsAccountingAccountsSetupId { get; set; }

        [Column("sat_codes_id")]
        public int SatCodesId { get; set; }

        [MaxLength(100)]
        [Column("accounting_account_key")]
        public string AccountingAccountKey { get; set; } = string.Empty;

        [MaxLength(200)]
        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("sat_currency_id")]
        public int SatCurrencyId { get; set; }

        [Column("nature_id")]
        public int NatureId { get; set; }

        [Column("parent_accounting_account_id")]
        public int ParentAccountingAccountId { get; set; }

        [Column("is_detail")]
        public bool IsDetail { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow.AddHours(-6);

        [Column("is_active")]
        [Required]
        public bool IsActive { get; set; }

        [ForeignKey(nameof(AccountingAccountId))]
        public virtual AccountingAccount? AccountingAccountsFK { get; set; }

        [ForeignKey(nameof(SatCurrencyId))]
        public virtual SatCurrency? SatCurrencies { get; set; }

        [ForeignKey(nameof(NatureId))]
        public virtual Nature? Natures { get; set; }

        [ForeignKey(nameof(SatCodesId))]
        public virtual SatCode? SatCodes {  get; set; }

        [ForeignKey(nameof(FiscalYearsAccountingAccountsSetupId))]
        public virtual FiscalYearsAccountingAccountsSetup? FiscalYearsAccountingAccountsSetup { get; set;}

        
    }
}
