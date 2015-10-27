using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Raven.Client;
using AspNet5Primer.SPA.Models.Home;

namespace AspNet5Primer.SPA.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        private readonly IAsyncDocumentSession _docSession;

        public ApiController(IAsyncDocumentSession docSession)
        {
            _docSession = docSession;
        }

        [HttpGet]
        public async Task<IEnumerable<BusinessProposal>> Get()
        {
            return await _docSession
                .Query<BusinessProposal>()
                .ToListAsync();
        }

        [HttpGet("{id}", Name = "GetById")]
        public async Task<IActionResult> Get(string id)
        {
            var bp = await _docSession
                .LoadAsync<BusinessProposal>(id);

            if (bp != null)
            {
                return new ObjectResult(bp);
            }

            return HttpNotFound();
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] BusinessProposal proposal)
        {
            await _docSession.StoreAsync(proposal);
            await _docSession.SaveChangesAsync();
            return CreatedAtRoute("GetById", new { id = proposal.Id }, proposal);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] BusinessProposal proposal)
        {
            await _docSession.StoreAsync(proposal);
            await _docSession.SaveChangesAsync();
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            _docSession.Delete(id);
            await _docSession.SaveChangesAsync();
            return new NoContentResult();
        }
    }
}