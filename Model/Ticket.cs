namespace TicketingClasses.Model
{
    public abstract class Ticket
    {
        //ticketID should switch to more dynamic assignment - see other notes below
        //database functionality will be better
        public int ticketID { get; set; }
        //maxID to track the last ticketID value Int16
        //public int maxID { get; set; }
        //public int ticketCount { get; set; }
        public string ticketSummary { get; set; }
        public string ticketStatus { get; set; }
        public string ticketPriority { get; set; }
        public string submittedBy { get; set; }
        public string assginedTo { get; set; }
        public string watching { get; set; }

    }
}

//Modify your Ticket system application - add support for different Ticket Types

//BugDefect
//Enhancement
//Task
//Tickets.csv

//TicketID, Summary, Status, Priority, Submitter, Assigned, Watching, Severity

//Enhancements.csv

//TicketID, Summary, Status, Priority, Submitter, Assigned, Watching, Software, Cost, Reason, Estimate

//Task.csv

//TicketID, Summary, Status, Priority, Submitter, Assigned, Watching, ProjectName, DueDate
