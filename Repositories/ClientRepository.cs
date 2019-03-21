using System.Collections.Generic;
using GraphQL.NetCore.Abstract;
using GraphQL.NetCore.Models;

namespace GraphQL.NetCore.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public IEnumerable<Models.Client> GetClients()
        {
            return new List<Models.Client>
            {
                new Models.Client
                {
                    Age = 15,
                    Email = "testuser1@email.com",
                    FullName = "Test User1",
                    UserName = "test1"
                },
                new Models.Client
                {
                    Age = 21,
                    Email = "testuser2@email.com",
                    FullName = "Test User2",
                    UserName = "test2"
                },
                 new Models.Client
                {
                    Age = 32,
                    Email = "testuser3@email.com",
                    FullName = "Test User3",
                    UserName = "test3"
                },
                 new Models.Client
                {
                    Age = 23,
                    Email = "testuser4@email.com",
                    FullName = "Test User4",
                    UserName = "test4"
                },
                 new Models.Client
                {
                    Age = 17,
                    Email = "testuser5@email.com",
                    FullName = "Test User5",
                    UserName = "test5"
                },
                 new Models.Client
                {
                    Age = 45,
                    Email = "testuser6@email.com",
                    FullName = "Test User6",
                    UserName = "test6"
                }
            };
        }
    }
}