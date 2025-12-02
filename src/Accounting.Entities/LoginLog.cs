using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class LoginLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("login_log_id")]
        public int loginLogId { get; set; }


        [Column("date_login")]
        public DateTime dateLogin {  get; set; }

        [MaxLength(500)]
        [Column("comment")]
        public string comment { get; set; }

        [Column("created_at")]
        public DateTime createdAt { get; set; } = DateTime.UtcNow;

        [Column("is_active")]
        public bool isActive { get; set; }

        [Column("user_id")]
        public int userId { get; set; }

        [ForeignKey(nameof(userId))]
        public virtual User { get; set;}
}
