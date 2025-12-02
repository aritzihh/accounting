using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class User
    {

        [Key]
        [Column("user_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Column("first_name")]
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [Column("maternal_surname")]
        [MaxLength(50)]
        public string? MaternalSurname { get; set; }

        [Column("paternal_surname")]
        [MaxLength(50)]
        public string? PaternalSurname { get; set; }

        [Required]
        [Column("username")]
        [MaxLength(50)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [Column("password_hash")]
        [MaxLength(250)]
        public string PasswordHash { get; set; } = string.Empty;

        [Column("email")]
        [MaxLength(100)]
        [EmailAddress]
        public string? Email { get; set; }

        [Column("is_active")]
        public bool? IsActive { get; set; } = true;

        [Column("created_at", TypeName = "datetime2(3)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedAt { get; set; }

        [Column("updated_at", TypeName = "datetime2(3)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }

    }
}
