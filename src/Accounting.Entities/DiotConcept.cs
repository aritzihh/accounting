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
        public int diotConceptId { get; set; }

        [MaxLength(5)]
        [Column("diot_key_concept")]
        public string diotKeyConcept { get; set; }

        [MaxLength(500)]
        [Column("diot_description")]
        public string diotDescription {  get; set; }

        [Column("debtor")]
        public bool debtor {  get; set; }

        [Precision(6, 2)]
        [Column("value_concept")]
        public decimal valueConcept { get; set; }

        [Column("created_at")]
        public DateTime createdAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime updatedAt { get; set; }

        [Column("is_active")]
        public bool isActive { get; set; }
    }
}
