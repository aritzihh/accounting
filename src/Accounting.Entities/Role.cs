using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    [Table("roles")]
    public class Role
    {
        [Key]
        [Column("role_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; }

        [Column("name")]
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Column("description")]
        [StringLength(250)]
        public string? Description { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow.AddHours(-6);

        [Column("is_active")]
        [Required]
        public bool IsActive { get; set; }
    }
}
