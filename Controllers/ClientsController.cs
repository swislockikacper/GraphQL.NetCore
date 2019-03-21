using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GraphQL.NetCore.Abstract;

namespace GraphQL.NetCore.Controllers
{
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IGraphQLService service;

        public ClientsController(IGraphQLService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("api/Clients")]
        public async Task Get()
            => await service.GetResult(HttpContext);
    }
}