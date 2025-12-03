using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Entities
{
    public class EntityBase
    {
        [NotMapped]
        public int Id { get; set; }
        [NotMapped]
        public bool IsActive { get; set; }

    }
}
