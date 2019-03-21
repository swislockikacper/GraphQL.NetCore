using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace GraphQL.NetCore.Abstract
{
    public interface IGraphQLService
    {
        Task GetResult(HttpContext httpContext);
    }
}