using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    public class Merchant
    {
        
        public long MerchantId { get; set; }
        [MaxLength(100)]
        public string ContactPersonFirstname { get; set; }
        [MaxLength(100)]
        public string ContactPersonLastname { get; set; }
        [MaxLength(150)]
        public string EmailAddress { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        [MaxLength(250)]
        public string Website { get; set; }
        [MaxLength(100)]
        public string Location { get; set; }
        [MaxLength(150)]
        public string Profession { get; set; }
        public long ProfessionId { get; set; }
        public long Services { get; set; }
        [MaxLength(250)]
        public string ImageName { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(150)]
        public string City { get; set; }
        [MaxLength(100)]
        public string State { get; set; }
        public long StateId { get; set; }
        [MaxLength(150)]
        public string LocalGovt { get; set; }
        public long LocalGovtId { get; set; }
        [MaxLength(150)]
        public string EnrollerName { get; set; }
        public string EnrollerUserId { get; set; }
        public string Status { get; set; }
        public Nullable<DateTime> DateRegistered { get; set; }
    }
}
