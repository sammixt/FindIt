using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class StateRepository : MapperConfig, IStateRepository
    {
        //Get all states 
        //Get State by state ID
        FindItDbContext dbContext;
        //IMapper mapper;
        public StateRepository(FindItDbContext _dbContext)
        {
            dbContext = _dbContext;
            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<State, DTO.State>().ReverseMap();
            //});
            //mapper = config.CreateMapper();
        }

        public IEnumerable<DTO.State> GetAllState()
        {
            try
            {
                var states = dbContext.States.ToList();
                var dto = mapper.Map<List<State>, List<DTO.State>>(states);
                return dto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DTO.State GetStateById(int Id)
        {
            try
            {
                var states = dbContext.States.Find(Id);
                var dto = mapper.Map<State, DTO.State>(states);
                return dto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
