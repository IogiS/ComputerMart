using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCW1
{
    [Table("CHARACTERISTIC_COMP")]
    class CharacteristicComp
    {
        [Key] 
        public int ID_CHAR { get; set; }
        public int ID_COMPONENT { get; set; }
        public int ID_CHARACTERISTIC { get; set; }
        public string CC_VALUE { get; set; }

    }
}
