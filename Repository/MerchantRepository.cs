using DataAccess;
using DTO.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Repository
{
    public class MerchantRepository : MapperConfig, IMerchantRepository
    {

        //get merchant by enrole username
        //get all merchant


        //add merchant -- add verification details
        //disable or delete merchant
        //update merchant
        FindItDbContext dbContext;
        public MerchantRepository(FindItDbContext _dbContext)
        {
            dbContext = _dbContext;

        }

        public int AddMerchant(DTO.Merchant model)
        {
            var merchant = mapper.Map<DTO.Merchant, Merchant>(model);
            dbContext.Add(merchant);
            var saveMerchant = dbContext.SaveChanges();
            return saveMerchant;
        }

        public int UpdateMerchant(DTO.Merchant model)
        {
            var merchant = mapper.Map<DTO.Merchant, Merchant>(model);
            dbContext.Update(model);
            var saveMerchant = dbContext.SaveChanges();
            return saveMerchant;
        }

        //get merchant by ID;
        public DTO.Merchant GetMerchantById(long Id)
        {
            try
            {
                var merchant = dbContext.Mechants.Find(Id);
                var merchantDto = mapper.Map<Merchant, DTO.Merchant>(merchant);
                return merchantDto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //get merchant by Email Address
        public DTO.Merchant GetMerchantByEmail(string email)
        {
            try
            {
                var merchant = dbContext.Mechants.FirstOrDefault(x => x.EmailAddress == email.Trim());
                var merchantDto = mapper.Map<Merchant, DTO.Merchant>(merchant);
                return merchantDto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //get merchant by professionId
        public List<DTO.Merchant> GetMerchantByProfession(long Id)
        {
            try
            {
                var merchant = dbContext.Mechants.Where(x => x.ProfessionId == Id).ToList();
                var merchantDto = mapper.Map<List<Merchant>, List<DTO.Merchant>>(merchant);
                return merchantDto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //get merchant by state
        public List<DTO.Merchant> GetMerchantByState(long Id)
        {
            try
            {
                var merchant = dbContext.Mechants.Where(x => x.StateId == Id).ToList();
                var merchantDto = mapper.Map<List<Merchant>, List<DTO.Merchant>>(merchant);
                return merchantDto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //get merchant by lga
        public List<DTO.Merchant> GetMerchantByLga(long Id)
        {
            try
            {
                var merchant = dbContext.Mechants.Where(x => x.LocalGovtId == Id).ToList();
                var merchantDto = mapper.Map<List<Merchant>, List<DTO.Merchant>>(merchant);
                return merchantDto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //get merchant by status
        public List<DTO.Merchant> GetMerchantByStatus(string status)
        {
            try
            {
                var merchant = dbContext.Mechants.Where(x => x.Status == status).ToList();
                var merchantDto = mapper.Map<List<Merchant>, List<DTO.Merchant>>(merchant);
                return merchantDto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //get merchant by services []
        public List<DTO.Merchant> GetMerchantByStatus(long[] service)
        {
            try
            {
                var merchant = dbContext.Mechants.Where(x => service.Contains(x.Services)).ToList();
                var merchantDto = mapper.Map<List<Merchant>, List<DTO.Merchant>>(merchant);
                return merchantDto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //get merchant by enrole username
        public List<DTO.Merchant> GetMerchantByRegisterer(string registrar)
        {
            try
            {
                var merchant = dbContext.Mechants.Where(x => x.EnrollerUserId == registrar).ToList();
                var merchantDto = mapper.Map<List<Merchant>, List<DTO.Merchant>>(merchant);
                return merchantDto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
