using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.Entities
{
    public class DailyCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("daily_codes_id")]
        public int DailyCodesId { get; set; }

        [Column("types_policies_id")]
        public int TypesPoliciesId { get; set; }

        [MaxLength(5)]
        [Column("daily_code_key")]
        public string DailyCodeKey { get; set; } = string.Empty;

        [MaxLength(300)]
        [Column("description")]
        public string Description { get; set; } = string.Empty;

        [Column("request_beneficiary")]
        public bool RequestBeneficiary { get; set; }

        [MaxLength(300)]
        [Column("sat_description")]
        public string SatDescription { get; set; } = string.Empty;

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow.AddHours(-6);

        [Column("is_active")]
        [Required]
        public bool IsActive { get; set; }

        [ForeignKey(nameof(TypesPoliciesId))]
        public virtual TypesPolicy? TypesPolicy { get; set; }
    }
}
