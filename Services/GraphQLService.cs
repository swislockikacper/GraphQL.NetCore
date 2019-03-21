using System.IO;
using System.Threading.Tasks;
using GraphQL.Http;
using GraphQL.NetCore.Abstract;
using GraphQL.NetCore.Queries;
using GraphQL.Types;
using Microsoft.AspNetCore.Http;

namespace GraphQL.NetCore.Services
{
    public class GraphQLService : IGraphQLService
    {
        private readonly IClientRepository repository;

        public GraphQLService(IClientRepository repository)
        {
            this.repository = repository;
        }

        public async Task GetResult(HttpContext httpContext)
        {
            using (var streamReader = new StreamReader(httpContext.Request.Body))
            {
                var query = await streamReader.ReadToEndAsync();

                var result = await new DocumentExecuter()
                            .ExecuteAsync(options =>
                            {
                                options.Schema = new Schema() { Query = new ClientsQuery(repository) };
                                options.Query = query;
                            })
                            .ConfigureAwait(false);

                await WriteResult(httpContext, result);
            }
        }

        private async Task WriteResult(HttpContext httpContext, ExecutionResult result)
        {
            var json = new DocumentWriter(indent: true).Write(result);
            httpContext.Response.StatusCode = 200;
            httpContext.Response.ContentType = "application/json";
            await httpContext.Response.WriteAsync(json);
        }
    }
}