using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Entities
{
    public class SatCurrency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("sat_currency_id")]
        public int satCurrencyId { get; set; }

        [MaxLength(10)]
        [Column("code")]
        public string code { get; set; }

        [MaxLength(255)]
        [Column("description")]
        public string description { get; set; }

        [Column("decimal_places")]
        public int decimalPlaces { get; set; }

        [Column("start_date")]
        public DateTime startDate { get; set; }

        [Column("end_date")]
        public DateTime endDate { get; set; }

        [Column("is_active")]
        public bool isActive { get; set; }

        [Column("created_at")]
        public DateTime createdAt { get; set; } = DateTime.Now;

        [Column("updated_at")]
        public DateTime updatedAt { get; set; }
    }
}
