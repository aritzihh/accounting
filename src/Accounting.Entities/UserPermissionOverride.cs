using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class UserPermissionOverride
    {
        [Key]
        [Column("user_permission_override_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserPermissionOverrideId { get; set; }

        [Column("user_id")]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        [Column("permission_id")]
        [ForeignKey(nameof(Permission))]
        public int PermissionId { get; set; }

        [Column("override_type")]
        [Required]
        [StringLength(10)]
        public string OverrideType { get; set; } = string.Empty;

        [Column("reason")]
        [StringLength(250)]
        public string? Reason { get; set; }

        [Column("created_at")]
        [Required]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        [Required]
        public DateTime UpdatedAt { get; set; }

        [Column("is_active")]
        [Required]
        public bool IsActive { get; set; } = true;  

        public virtual User? User { get; set; }
        public virtual Permission? Permission { get; set; }

    }
}
