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
        [Column("exchange_rate")]
        [Precision(18, 6)]
        public decimal ExchangeRate { get; set; }

        [Required]
        [Column("date")]
        public DateTime Date { get; set; }

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; }

        [Required]
        [Column("created_at"]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at"]        
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow.AddHours(-6);


        public virtual SatCurrency? SatCurrency { get; set; }

    }
}
