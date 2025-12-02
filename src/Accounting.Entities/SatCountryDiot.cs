using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class SatCountryDiot
    {

        [Key]
        [Column("sat_country_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SatCountryId { get; set; }

        [Required]
        [Column("key_country")]
        [MaxLength(10)]
        public string KeyCountry { get; set; } = string.Empty;

        [Required]
        [Column("description")]
        [MaxLength(250)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; }

    }
}
