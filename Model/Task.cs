using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingClasses.Model
{
    class Task : Ticket
    {
        //TicketID, Summary, Status, Priority, Submitter, Assigned, Watching, ProjectName, DueDate
        public string projectName { get; set; }
        public DateTime dueDate { get; set; }
    }
}
