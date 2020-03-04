using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class VerifiedInfo
    {
        public long VerifyId { get; set; }
        public long MerchantId { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string BusinessName { get; set; }
        public string VerifierName { get; set; }
        public string DateVerified { get; set; }
    }
}
