using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKustoWithPrompt.Models
{
    internal class KustoResponseModel
    {
        public string IncidentId { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string AgentAlias { get; set; }
    }
}
