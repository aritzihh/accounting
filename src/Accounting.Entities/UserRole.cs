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
    public class UserRole
    {

        [Key]
        [Column("user_role_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserRoleId { get; set; }

        [Required]
        [Column("user_id")]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        [Required]
        [Column("role_id")]
        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }

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

        //



        public virtual User? User { get; set; }

        public virtual Role? Role { get; set; }

    }
}
