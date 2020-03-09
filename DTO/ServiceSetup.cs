using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    public class ServiceSetup
    {
        
        public long ServiceId { get; set; }
        [MaxLength(250)]
        public string ServiceName { get; set; }
        public Nullable<DateTime> DateEntered { get; set; }
    }
}
