using DataAccess;
using System.Collections.Generic;

namespace Repository
{
    public interface ILocalGovRepository
    {
        IEnumerable<LocalGovt> GetAllLocalGovt();
        LocalGovt GetLocalGovt(int Id);
        IEnumerable<LocalGovt> GetLocalGovtByState(int Id);
    }
}