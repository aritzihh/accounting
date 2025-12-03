using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class SatDocumentType
    {

        [Key]
        [Column("document_type_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DocumentTypeId { get; set; }

        [Required]
        [Column("code")]
        [MaxLength(5)]
        public string Code { get; set; } = string.Empty;

        [Required]
        [Column("description")]
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;

        [Column("start_date")]
        public DateTime? StartDate { get; set; }

        [Column("end_date")]
        public DateTime? EndDate { get; set; }

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
