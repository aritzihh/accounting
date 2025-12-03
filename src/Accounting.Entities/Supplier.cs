using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    [Table("suppliers")]
    public class Supplier
    {
        [Key]
        [Column("supplier_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierId { get; set; }

        [Column("rfc")]
        [StringLength(13)]
        public string? Rfc { get; set; }

        [Column("name")]
        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [Column("sat_type_third_diot")]
        [StringLength(10)]
        public string? SatTypeThirdDiot { get; set; }

        [Column("sat_country_id")]
        [ForeignKey(nameof(SatCountryDiot))]
        public int? SatCountryId { get; set; }

        [Column("tax_id")]
        [StringLength(50)]
        public string? TaxId { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        public DateTime CreatedAt { get; set; }

        [Column("is_active")]
        [Required]
        public bool IsActive { get; set; }

        
        public virtual SatCountryDiot? SatCountryDiot { get; set; }
        public virtual ICollection<DiotTransaction>? DiotTransactions { get; set; }
    }
}
