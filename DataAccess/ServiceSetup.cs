using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class ServiceSetup
    {
        public long ServiceId { get; set; }
        public string ServiceName { get; set; }
        public Nullable<DateTime> DateEntered { get; set; }
    }
}
