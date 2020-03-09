using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Repository
{
    public class LocalGovRepository : MapperConfig, ILocalGovRepository
    {
        //Get all local govts 
        //Get local govt by local govt ID
        //Get local govt by state ID
        FindItDbContext dbContext;
        //public IMapper mapper;
        public LocalGovRepository(FindItDbContext _dbContext)
        {
            dbContext = _dbContext;
            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<LocalGovt, DTO.LocalGovt>().ReverseMap();
            //});
            //mapper = config.CreateMapper();
        }

        public IEnumerable<DTO.LocalGovt> GetAllLocalGovt()
        {
            try
            {
                var localGov = dbContext.LocalGovts.ToList();
                var dto = mapper.Map<List<LocalGovt>, List<DTO.LocalGovt>>(localGov);
                return dto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<DTO.LocalGovt> GetLocalGovtByState(int Id)
        {
            try
            {
                var localGov = dbContext.LocalGovts.Where(m => m.StateId == Id).ToList();
                var dto = mapper.Map<List<LocalGovt>, List<DTO.LocalGovt>>(localGov);
                return dto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DTO.LocalGovt GetLocalGovt(int Id)
        {
            try
            {
                var localGov = dbContext.LocalGovts.Find(Id);
                var dto = mapper.Map<LocalGovt, DTO.LocalGovt>(localGov);
                return dto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
