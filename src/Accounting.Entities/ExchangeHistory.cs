using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class ExchangeHistory
    {

        [Key]
        [Column("exchange_history_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExchangeHistoryId { get; set; }

        [Required]
        [Column("sat_currency_id")]
        [ForeignKey(nameof(SatCurrency))]
        public int SatCurrencyId { get; set; }

        [Required]
        [Column("exchange_rate", TypeName = "decimal(18, 6)")]
        public decimal ExchangeRate { get; set; }

        [Required]
        [Column("date")]
        public DateTime Date { get; set; }

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; }

        [Required]
        [Column("created_at", TypeName = "datetime2(3)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at", TypeName = "datetime2(3)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }

        // Navigation property
        public virtual SatCurrency? SatCurrency { get; set; }

    }
}
