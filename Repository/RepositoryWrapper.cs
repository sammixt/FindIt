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
        IMerchantRepository merchantRepository;

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

        public IMerchantRepository MerchantRepo
        {
            get
            {
                if (merchantRepository == null)
                {
                    merchantRepository = new MerchantRepository(findItDbContext);
                }
                return merchantRepository;
            }
        }

    }
}
