using GraphQL.NetCore.Models;
using GraphQL.Types;

namespace GraphQL.NetCore.Types
{
    public class ClientType : ObjectGraphType<Models.Client>
    {
        public ClientType()
        {
            Field(c => c.FullName);
            Field(c => c.UserName);
            Field(c => c.Email);
            Field(c => c.Age);
        }
    }
}