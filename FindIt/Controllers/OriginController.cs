using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace FindIt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OriginController : ControllerBase
    {
        IRepositoryWrapper repo;
        public OriginController(IRepositoryWrapper _repo)
        {
            repo = _repo;
        }
        // GET: api/Origin
        [HttpGet]
        [Route("getstate")]
        public IEnumerable<object> Get()
        {
            var states = repo.StateRepository.GetAllState();
            return states;
        }

        // GET: api/Origin/5
        [HttpGet]
        [Route("getstate/{id}")]
        public object Get(int id)
        {
            var state = repo.StateRepository.GetStateById(id);
            return state;
        }

        [HttpGet]
        [Route("getlgabystate/{id}")]
        public IEnumerable<object> GetLgaByState(int id)
        {
            var lga = repo.GovRepository.GetLocalGovtByState(id);
            return lga;
        }

        [HttpGet]
        [Route("getlga")]
        public IEnumerable<object> GetLga()
        {
            var lga = repo.GovRepository.GetAllLocalGovt();
            return lga;
        }

        [HttpGet]
        [Route("getlga/{id}")]
        public object GetLga(int id)
        {
            var lga = repo.GovRepository.GetLocalGovt(id);
            return lga;
        }


        // POST: api/Origin
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Origin/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
