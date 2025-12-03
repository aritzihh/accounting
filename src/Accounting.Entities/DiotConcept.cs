using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class DiotConcept
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("diot_concept_id")]
        public int DiotConceptId { get; set; }

        [MaxLength(5)]
        [Column("diot_key_concept")]
        public string DiotKeyConcept { get; set; } = string.Empty;

        [MaxLength(500)]
        [Column("diot_description")]
        public string DiotDescription {  get; set; } = string.Empty;

        [Column("debtor")]
        public bool Debtor {  get; set; }

        [Precision(6, 2)]
        [Column("value_concept")]
        public decimal ValueConcept { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow.AddHours(-6);

        [Column("is_active")]
        [Required]
        public bool IsActive { get; set; }
    }
}
