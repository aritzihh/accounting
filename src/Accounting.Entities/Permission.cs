using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Entities
{
    public class Permission
    {

        [Key]
        [Column("permission_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PermissionId { get; set; }

        [Required]
        [Column("process_id")]
        [ForeignKey(nameof(Process))]
        public int ProcessId { get; set; }

        [Required]
        [Column("name")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Column("description")]
        [MaxLength(250)]
        public string? Description { get; set; }

        [Required]
        [Column("created_at", TypeName = "datetime2(3)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at", TypeName = "datetime2(3)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; }

        // Navigation property
        [DeleteBehavior(DeleteBehavior.Cascade)]
        public virtual Process? Process { get; set; }

    }
}
