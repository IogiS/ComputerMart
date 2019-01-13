using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCW1
{
    [Table("COMP_COMPONENT")]
    class CompComponent
    {
        [Key]
        public int ID_COMP_COMPONENT { get; set; }
        public int ID_COMPUTER { get; set; }
        public int ID_COMPONENT { get; set; }


    }
}
