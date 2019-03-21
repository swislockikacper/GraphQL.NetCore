using System.Collections.Generic;
using GraphQL.NetCore.Models;

namespace GraphQL.NetCore.Abstract
{
    public interface IClientRepository
    {
        IEnumerable<Models.Client> GetClients();
    }
}