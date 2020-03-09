using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess
{
   public class Profession
    {
        [Key]
        public long Id { get; set; }
        public long MerchantId { get; set; }
        public long ProfessionId { get; set; }
    }
}
