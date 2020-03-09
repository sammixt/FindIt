using DataAccess;
using System.Collections.Generic;

namespace Repository
{
    public interface ILocalGovRepository
    {
        IEnumerable<DTO.LocalGovt> GetAllLocalGovt();
        DTO.LocalGovt GetLocalGovt(int Id);
        IEnumerable<DTO.LocalGovt> GetLocalGovtByState(int Id);
    }
}