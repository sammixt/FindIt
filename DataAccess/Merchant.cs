using System;

namespace DataAccess
{
    public class Merchant
    {
        public long MerchantId { get; set; }
        public string ContactPersonFirstname { get; set; }
        public string ContactPersonLastname { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string Location { get; set; }
        public string Profession { get; set; }
        public long ProfessionId { get; set; }
        public string Services { get; set; }
        public string ImageName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long StateId { get; set; }
        public string LocalGovt { get; set; }
        public long LocalGovtId { get; set; }
        public string EnrollerName { get; set; }
        public string EnrollerUserId { get; set; }
        public string Status { get; set; }
        public Nullable<DateTime> DateRegistered { get; set; }
    }
}
