using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCW1
{
    [Table("CHARACTERISTIC")]
    class Characteristic
    {
        [Key]
        public int ID_CHARACTERISTIC { get; set; }
        public string CHARA_NAME { get; set; }
    }
}
