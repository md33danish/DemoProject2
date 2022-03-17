using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EngineersAppWebCore;
using Microsoft.Extensions.Configuration;

namespace EngineersAppWebCore
{
    
    public class Connection
    {
        public static string connectionstring = "";
        public static void Set(IConfiguration config)
        {
            connectionstring = config.GetConnectionString("ClaimsiteV2FnolDatabase");
        }
    }
}
