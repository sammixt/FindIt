using DataAccess;
using System.Collections.Generic;

namespace Repository
{
    public interface IStateRepository
    {
        IEnumerable<DTO.State> GetAllState();
        DTO.State GetStateById(int Id);
    }
}