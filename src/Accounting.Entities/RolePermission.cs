using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class RolePermission
    {

        [Key]
        [Column("role_permission_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RolePermissionId { get; set; }

        [Required]
        [Column("role_id")]
        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }

        [Required]
        [Column("permission_id")]
        [ForeignKey(nameof(Permission))]
        public int PermissionId { get; set; }

        [Required]
        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow.AddHours(-6);

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; }


        public virtual Role? Role { get; set; }
        public virtual Permission? Permission { get; set; }

    }
}
