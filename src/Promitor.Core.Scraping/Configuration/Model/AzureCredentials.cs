﻿using Promitor.Agents.Core.Configuration.Server;

namespace Promitor.Core.Scraping.Configuration.Model
{
    public class AzureCredentials
    {
        public string ApplicationId { get; set; }
        public string Secret { get; set; }
        public string ManagedIdentityId { get; set; }
        public AuthenticationMode AuthenticationMode { get; set; }
    }
}