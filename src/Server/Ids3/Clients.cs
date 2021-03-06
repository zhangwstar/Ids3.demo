﻿using System.Collections.Generic;
using IdentityServer3.Core.Models;

namespace Server.Ids3
{
    public static class Clients
    {
        public static IEnumerable<Client> All => new[]
        {
            ImplicitClient
        };

        private static Client ImplicitClient
        {
            get
            {
                var host = "http://client.implicit.dev/";

                return new Client
                {
                    Enabled = true,
                    ClientName = "Implicit Client",
                    ClientId = "implicit-client",
                    Flow = Flows.Implicit,
                    RedirectUris = new List<string>
                    {
                        host
                    },
                    //退出登录后重定向的地址。
                    PostLogoutRedirectUris = new List<string>
                    {
                        host
                    },
                    //禁止退出登录的确认提示页面，直接退出。
                    RequireConsent = false,
                    AllowAccessToAllScopes = true,
                    LogoutUri = host + "account/logout-callback",
                    LogoutSessionRequired = true
                };
            }
        }
    }
}