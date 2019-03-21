using GraphQL.NetCore.Abstract;
using GraphQL.NetCore.Types;
using GraphQL.Types;

namespace GraphQL.NetCore.Queries
{
    public class ClientsQuery : ObjectGraphType
    {
        public ClientsQuery(IClientRepository repository)
        {
            Field<ListGraphType<ClientType>>(
                "clients",
                resolve: context => repository.GetClients());
        }
    }
}