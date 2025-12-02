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
        public int paymentWayId { get; set; }

        [MaxLength(5)]
        [Column("code")]
        public string code { get; set; }

        [MaxLength(255)]
        [Column("description")]
        public string description { get; set; }

        [Column("start_date")]
        public DateTime startTime { get; set; }

        [Column("end_date")]
        public DateTime endTime { get; set; }

        [Column("is_active")]
        public bool isActive { get; set; }

        [Column("created_at")]
        public DateTime createdAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime updatedAt { get; set; }

        [Column("bank_required")]
        public bool bankRequired { get; set; }
    }
}
