using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingClasses.Model
{
    class Enhance : Ticket
    {
        // TicketID, Summary, Status, Priority, Submitter, Assigned, Watching, Software, Cost, Reason, Estimate

        public string software { get; set; }
        public float cost { get; set; }
        public string reason { get; set; }
        public float estimate { get; set; }
    }
}
