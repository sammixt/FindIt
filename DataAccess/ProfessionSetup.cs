using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess
{
    public class ProfessionSetup
    {
        [Key]
        public long ProfessionId { get; set; }
        [MaxLength(250)]
        public string Profession { get; set; }
        public Nullable<DateTime> DateEntered { get; set; }
    }
}
