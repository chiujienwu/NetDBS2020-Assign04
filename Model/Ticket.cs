using System;

namespace TicketingClasses.Model
{
    public abstract class Ticket
    {
        public int ticketID { get; set; }
        public string ticketSummary { get; set; }
        public string ticketStatus { get; set; }
        public string ticketPriority { get; set; }
        public string submittedBy { get; set; }
        public string assginedTo { get; set; }
        public string watching { get; set; }
        public string filePath { get; set; }

        public abstract void Display();

    }
}
