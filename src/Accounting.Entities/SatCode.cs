using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    [Table("sat_codes")]
    public class SatCode
    {
        [Key]
        [Column("sat_code_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SatCodeId { get; set; }

        [Column("code")]
        [Required]
        [StringLength(100)]
        public string Code { get; set; } = string.Empty;

        [Column("description")]
        [StringLength(400)]
        public string? Description { get; set; }

        [Column("is_active")]
        [Required]
        public bool IsActive { get; set; } = true;

        [Column("created_at")]
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [Column("nature_id")]
        [ForeignKey(nameof(Nature))]
        public int? NatureId { get; set; }

        // Navegación
        public virtual Nature? Nature { get; set; }
    }
}
