using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Dto.Response
{
    public class BankResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string BankCode { get; set; } = string.Empty;

    }
}
