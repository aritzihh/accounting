using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Entities
{
    public class SatCurrency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("sat_currency_id")]
        public int SatCurrencyId { get; set; }

        [MaxLength(10)]
        [Column("code")]
        public string Code { get; set; } = string.Empty;

        [MaxLength(255)]
        [Column("description")]
        public string Description { get; set; } = string.Empty;

        [Column("decimal_places")]
        public int DecimalPlaces { get; set; }

        [Column("start_date")]
        public DateTime StartDate { get; set; }

        [Column("end_date")]
        public DateTime EndDate { get; set; }

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
