using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Repository
{
    public class LocalGovRepository : ILocalGovRepository
    {
        //Get all local govts 
        //Get local govt by local govt ID
        //Get local govt by state ID
        FindItDbContext dbContext;
        public LocalGovRepository(FindItDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IEnumerable<LocalGovt> GetAllLocalGovt()
        {
            try
            {
                var localGov = dbContext.LocalGovts.ToList();
                return localGov;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<LocalGovt> GetLocalGovtByState(int Id)
        {
            try
            {
                var localGov = dbContext.LocalGovts.Where(m => m.StateId == Id).ToList();
                return localGov;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LocalGovt GetLocalGovt(int Id)
        {
            try
            {
                var localGov = dbContext.LocalGovts.Find(Id);
                return localGov;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
