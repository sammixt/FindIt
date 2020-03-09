using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    public class Service
    {
       
       public long Id {get; set;}
       public long MerchantId { get; set;}
       public long ServiceId { get; set;}
    }
}
