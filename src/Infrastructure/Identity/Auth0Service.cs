using Auth0.ManagementApi;
using Auth0.ManagementApi.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using Talks.Application.Common.Interfaces;
using Talks.Domain.Enums;

namespace Talks.Infrastructure.Identity
{
    public class Auth0Service : IAuth0Service
    {
        private readonly ManagementApiClient _managementApiClient;

        public Auth0Service(ManagementApiClient managementApiClient)
        {
            _managementApiClient = managementApiClient;
        }

        public async Task<bool> AddRoleToUserAsync(string userId, Roles role)
        {
            try
            {
                var auth0Roles = await _managementApiClient.Roles.GetAllAsync(new GetRolesRequest { NameFilter = role.ToString() });

                if (auth0Roles.Paging.Length == 0)
                {
                    // TODO: throw RoleNotFoundException
                }

                var roles = auth0Roles.Select(role => role.Id).ToArray();

                await _managementApiClient.Users.AssignRolesAsync(userId, new AssignRolesRequest
                {
                    Roles = roles
                });
            }
            catch (Exception e)
            {
                // TODO: throw AssignRoleException
                throw;
            }

            return true;
        }
    }
}
