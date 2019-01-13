using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCW1
{
    [Table("REQUEST")]
    class Request
    {
        [Key]
        public int REQUEST_ID { get; set; }
        public int ID_COMPUTER { get; set; }
        public int ID_CLIENT { get; set; }
        public DateTime REQUEST_DATE { get; set; }
        public int REQUEST_AMMOUNT { get; set; }
        public DateTime EXECUTION_DATE { get; set; }

    }
}

