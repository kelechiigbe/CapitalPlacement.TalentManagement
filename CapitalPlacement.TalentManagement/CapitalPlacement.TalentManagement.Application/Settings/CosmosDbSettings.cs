using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.TalentManagement.Application.Settings
{
    public class CosmosDbSettings
    {
        public const string Name = "CosmosDbSettings";
        public string AccountEndPoint { get; set; }
        public string AccountKey { get; set; }
        public string DatabaseName { get; set; }
    }
}
