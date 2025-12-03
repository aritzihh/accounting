using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class SatCfdiStatus
    {

        [Key]
        [Column("cfdi_status_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CfdiStatusId { get; set; }

        [Required]
        [Column("code")]
        [MaxLength(10)]
        public string Code { get; set; } = string.Empty;

        [Required]
        [Column("description")]
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;

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
