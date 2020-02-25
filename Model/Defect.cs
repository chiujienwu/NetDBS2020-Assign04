using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingClasses.Model
{
    class Defect : Ticket
    {
        ////TicketID, Summary, Status, Priority, Submitter, Assigned, Watching, Severity
        public string severity { get; set; }
    }
}
