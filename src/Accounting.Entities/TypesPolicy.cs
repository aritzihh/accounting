using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class TypesPolicy
    {

        [Key]
        [Column("types_policies_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypesPoliciesId { get; set; }

        [Required]
        [Column("description")]
        [MaxLength(200)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; }

    }
}
