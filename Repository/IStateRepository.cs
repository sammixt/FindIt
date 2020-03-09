using DataAccess;
using System.Collections.Generic;

namespace Repository
{
    public interface IStateRepository
    {
        IEnumerable<State> GetAllState();
        State GetStateById(int Id);
    }
}