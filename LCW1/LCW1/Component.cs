using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCW1
{
    [Table("COMPONENT")]
    class Component
    {
        [Key]
        public int ID_COMPONENT { get; set; }
        public string MODEL { get; set; }
        public string COMPANY { get; set; }
        public string TYPE_COMPONENTS { get; set; }


    }
}
