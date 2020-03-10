using DTO;
using System.Collections.Generic;

namespace Repository
{
    public interface IMerchantRepository
    {
        int AddMerchant(Merchant model);
        Merchant GetMerchantByEmail(string email);
        Merchant GetMerchantById(long Id);
        List<Merchant> GetMerchantByLga(long Id);
        List<Merchant> GetMerchantByProfession(long Id);
        List<Merchant> GetMerchantByRegisterer(string registrar);
        List<Merchant> GetMerchantByState(long Id);
        List<Merchant> GetMerchantByStatus(long[] service);
        List<Merchant> GetMerchantByStatus(string status);
        int UpdateMerchant(Merchant model);
    }
}