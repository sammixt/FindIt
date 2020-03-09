using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class StateRepository : IStateRepository
    {
        //Get all states 
        //Get State by state ID
        FindItDbContext dbContext;
        public StateRepository(FindItDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IEnumerable<State> GetAllState()
        {
            try
            {
                var states = dbContext.States.ToList();
                return states;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public State GetStateById(long Id)
        {
            try
            {
                var states = dbContext.States.Find(Id);
                return states;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
