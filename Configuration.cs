using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;
using IdentityModel;
using IdentityServer4;

namespace Identity
{
    public static class Configuration
    {
        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope("NotesWebAPI", "Web API")
            };

        public static IEnumerable<IdentityResource> IdentityResources =>
           new List<IdentityResource>
           {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
           };

        public static IEnumerable<ApiResource> ApiResources =>
            new List<ApiResource>
            {
                new ApiResource("EmployeesWebAPI", "Web API", new []
                    { JwtClaimTypes.Name})
                {
                    Scopes = {"NotesWebAPI"}
                }
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "employees-web-api",
                    ClientName = "Employees Web",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequireClientSecret = false,
                    RequirePkce = true,
                    RedirectUris =
                    {
                        "http://.../signin-oidc"
                    },
                    AllowedCorsOrigins =
                    {
                        "http://..."
                    },
                    PostLogoutRedirectUris =
                    {
                        "http:/.../signout-oidc"
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "EmployeesWebAPI"
                    },
                    AllowAccessTokensViaBrowser = true
                }
            };
    }
}
