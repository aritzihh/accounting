using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class Bank : EntityBase
    {

        //[Key]
        //[Column("bank_id")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int BankId { get; set; }

        [Required]
        [Column("name")]
        [MaxLength(150)]
        public string Name { get; set; } = string.Empty;

        [Column("bank_code")]
        [MaxLength(40)]
        public string? BankCode { get; set; }

        [Required]
        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow.AddHours(-6);

        //[Required]
        //[Column("is_active")]
        //public bool IsActive { get; set; }

    }
}
