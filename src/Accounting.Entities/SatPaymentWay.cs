using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class SatPaymentWay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("payment_way_id")]
        public int PaymentWayId { get; set; }

        [MaxLength(5)]
        [Column("code")]
        [Required]
        public string Code { get; set; } = string.Empty;

        [MaxLength(255)]
        [Column("description")]
        [Required]
        public string Description { get; set; } = string.Empty;

        [Column("start_date")]
        public DateTime StartTime { get; set; }

        [Column("end_date")]
        public DateTime EndTime { get; set; }

        [Column("is_active")]
        [Required]
        public bool IsActive { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow.AddHours(-6);

        [Column("bank_required")]
        public bool BankRequired { get; set; }
    }
}
