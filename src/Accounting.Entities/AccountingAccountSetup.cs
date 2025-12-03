using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class AccountingAccountSetup
    {
        [Key]
        [Column("accounting_account_setup_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountingAccountSetupId { get; set; }

        [Column("number_characters_level_1")]
        public int? NumbeCharactersLevel1 { get; set; }

        [Column("number_characters_level_2")]
        public int? NumbeCharactersLevel2 { get; set; }

        [Column("number_characters_level_3")]
        public int? NumbeCharactersLevel3 { get; set; }

        [Column("number_characters_level_4")]
        public int? NumbeCharactersLevel4 { get; set; }

        [Column("number_characters_level_5")]
        public int? NumbeCharactersLevel5 { get; set; }

        [Column("number_characters_level_6")]
        public int? NumbeCharactersLevel6 { get; set; }

        [Column("number_characters_level_7")]
        public int? NumbeCharactersLevel7 { get; set; }

        [Column("number_characters_level_8")]
        public int? NumbeCharactersLevel8 { get; set; }

        [Column("number_characters_level_9")]
        public int? NumbeCharactersLevel9 { get; set; }

        [Column("created_at")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        public DateTime created_at { get; set; }

        [Column("is_active")]
        [Required]
        public bool IsActive { get; set; }
    }
}
