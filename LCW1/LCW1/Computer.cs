using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCW1
{
    [Table("COMPUTER")]
    class Computer
    {
        [Key]
        public int ID_COMPUTER { get; set; }
        public string NAME_COMPUTER { get; set; }
        public string TYPE_COMPUTER { get; set; }


    }
}
