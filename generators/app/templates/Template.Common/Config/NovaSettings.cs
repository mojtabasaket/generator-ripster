﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Common.Config
{
  public  class NovaSettings
    {
        public Security Security { get; set; } = new Security();
        public List<string> ValidIssuers { get; set; }
        public Cors Cors { get; set; } = new Cors();

        public Consul Consul { get; set; } = new Consul();
        public string DefaultLanguage { get; set; }
        public FileSystem FileSystem { get; set; } = new FileSystem();
        public ClientToken ClientToken { get; set; } = new ClientToken();
    }

    public class Security
    {
        public Authentication Authentication { get; set; } = new Authentication();
    }

    public class Authentication
    {
        public IdentityServer IdentityServer { get; set; } = new IdentityServer();
    }

    public class IdentityServer
    {
        public string Authority { get; set; }
        public string ApiName { get; set; }
   
        
    }
    public class Consul
    {
        public string Host { get; set; }
        public string Uri { get; set; }

        public string RegisterName { get; set; }

    }
    public class Cors
    {
        public string AllowedOrigins { get; set; }
        public string AllowedMethods { get; set; }
        public string AllowedHeaders { get; set; }
        public string ExposedHeaders { get; set; }
        public bool AllowCredentials { get; set; }
        public int MaxAge { get; set; }
    }


    public class FileSystem
    {
        public string CustomerFilePath { get; set; }
 
    }


    public class ClientToken
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int ApplicationID { get; set; }

    }
}
