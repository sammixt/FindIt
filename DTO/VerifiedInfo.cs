using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    public class VerifiedInfo
    {
        
        public long VerifyId { get; set; }
        public long MerchantId { get; set; }
        public bool EmailAddress { get; set; }
        public bool PhoneNumber { get; set; }
        public bool Address { get; set; }
        public bool BusinessName { get; set; }
        [MaxLength(150)]
        public string VerifierName { get; set; }
        public Nullable<DateTime> DateVerified { get; set; }
    }
}
