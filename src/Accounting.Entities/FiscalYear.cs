using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    [Table("fiscal_years")]
    public class FiscalYear
    {
        [Key]
        [Column("fiscal_years_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FiscalYearsId { get; set; }

        [Column("company_id")]
        [Required]
        [ForeignKey(nameof(Company))]
        public int CompanyId { get; set; }

        [Column("year")]
        [Required]
        public int Year { get; set; }

        [Column("start_date")]
        [Required]
        public DateTime StartDate { get; set; }

        [Column("end_date")]
        [Required]
        public DateTime EndDate { get; set; }

        [Column("status")]
        [Required]
        [StringLength(5)]
        public string Status { get; set; } = string.Empty;

        [Column("opening_date")]
        [Required]
        public DateTime OpeningDate { get; set; }

        [Column("ending_date")]
        public DateTime? EndingDate { get; set; }

        [Column("created_at")]
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [Column("is_active")]
        [Required]
        public bool IsActive { get; set; } = true;

        // Navegación
        public virtual Company? Company { get; set; }
    }
}
