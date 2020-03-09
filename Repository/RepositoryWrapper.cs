using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        FindItDbContext findItDbContext;
        ILocalGovRepository govRepository;
        IStateRepository stateRepository;

        public RepositoryWrapper()
        {
            findItDbContext = new FindItDbContext();
        }
        public ILocalGovRepository GovRepository
        {
            get
            {
                if (govRepository == null)
                {
                    govRepository = new LocalGovRepository(findItDbContext);
                }
                return govRepository;
            }
        }

        public IStateRepository StateRepository
        {
            get
            {
                if (stateRepository == null)
                {
                    stateRepository = new StateRepository(findItDbContext);
                }
                return stateRepository;
            }
        }

    }
}
