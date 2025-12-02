using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    [Table("companies")]
    public class Company
    {
        [Key]
        [Column("company_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }

        [Column("name")]
        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [Column("rfc")]
        [StringLength(20)]
        public string? Rfc { get; set; }

        [Column("short_name")]
        [StringLength(100)]
        public string? ShortName { get; set; }

        [Column("tax_address")]
        [StringLength(300)]
        public string? TaxAddress { get; set; }

        [Column("created_at")]
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [Column("is_active")]
        [Required]
        public bool IsActive { get; set; } = true;

        [Column("tax_regime_id")]
        [Required]
        [ForeignKey(nameof(TaxRegime))]
        public int TaxRegimeId { get; set; }

        // Navegación
        public virtual TaxRegime? TaxRegime { get; set; }
        public virtual ICollection<FiscalYear>? FiscalYears { get; set; }
    }
}
