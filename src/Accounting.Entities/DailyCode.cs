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
        public int dailyCodesId { get; set; }

        [Column("types_policies_id")]
        public int typesPoliciesId { get; set; }

        [MaxLength(5)]
        [Column("daily_code_key")]
        public string dailyCodeKey { get; set; }

        [MaxLength(300)]
        [Column("description")]
        public string description { get; set; }

        [Column("request_beneficiary")]
        public bool requestBeneficiary { get; set; }

        [MaxLength(300)]
        [Column("sat_description")]
        public string satDescription { get; set; }

        [Column("created_at")]
        public DateTime createdAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime updatedAt { get; set; }

        [Column("is_active")]
        public bool isActive { get; set; }

        [ForeignKey(nameof(typesPoliciesId))]
        public virtual TypesPolicies TypesPolicies { get; set; }
    }
}
