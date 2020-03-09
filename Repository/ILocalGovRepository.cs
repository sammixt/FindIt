using DataAccess;
using System.Collections.Generic;

namespace Repository
{
    public interface ILocalGovRepository
    {
        IEnumerable<LocalGovt> GetAllLocalGovt();
        LocalGovt GetLocalGovt(long Id);
        IEnumerable<LocalGovt> GetLocalGovtByState(long Id);
    }
}