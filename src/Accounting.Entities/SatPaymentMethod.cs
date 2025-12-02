using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    [Table("sat_payment_methods")]
    public class SatPaymentMethod
    {
        [Key]
        [Column("payment_method_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentMethodId { get; set; }

        [Column("code")]
        [Required]
        [StringLength(5)]
        public string Code { get; set; } = string.Empty;

        [Column("description")]
        [Required]
        [StringLength(255)]
        public string Description { get; set; } = string.Empty;

        [Column("bank_required")]
        [Required]
        public bool BankRequired { get; set; } = false;

        [Column("start_date")]
        public DateTime? StartDate { get; set; }

        [Column("end_date")]
        public DateTime? EndDate { get; set; }

        [Column("is_active")]
        [Required]
        public bool IsActive { get; set; } = true;

        [Column("created_at")]
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
