using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess
{
    public class Service
    {
       [Key]
       public long Id {get; set;}
       public long MerchantId { get; set;}
       public long ServiceId { get; set;}
    }
}
