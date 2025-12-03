using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class TaxRegime
    {

        [Key]
        [Column("tax_regime_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaxRegimeId { get; set; }

        [Required]
        [Column("regime_code")]
        [MaxLength(100)]
        public string RegimeCode { get; set; } = string.Empty;

        [Column("regime_description")]
        [MaxLength(200)]
        public string? RegimeDescription { get; set; }

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; }

        [Required]
        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]        
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow.AddHours(-6);

    }
}
