using IdentityServer4;
using IdentityServer4.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace AuthenticationStoreAPI.Config
{
    public static class IdentityConfig
    {
        //APIs
        public static IEnumerable<ApiResource> GetAPIResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("StoreAPI","Store API coding challenge")
            };
        }

        //Servidor de autenticacion
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }

        //Clientes
        public static IEnumerable<Client> GetClients(IConfiguration configuration)
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = configuration.GetValue<string>("Client:ClientId"),
                    ClientName = "Back-Office Client",
                    AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,
                    RequireConsent = false,
                    ClientSecrets = {new Secret(configuration.GetValue<string>("Client:SecretKey").Sha256())},
                    RedirectUris = { $"signin"},
                    PostLogoutRedirectUris = { $"signout"},
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "StoreAPI",
                    },
                    AllowOfflineAccess = true,
                    AlwaysIncludeUserClaimsInIdToken = true 
                }
            };
        }

    }
}
