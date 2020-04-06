using System;

namespace TicketingClasses.Model
{
    public class Defect : Ticket
    {
        ////TicketID, Summary, Status, Priority, Submitter, Assigned, Watching, Severity
        public string _severity { get; set; }

        // Constructors

        public Defect() { }

        public Defect (int ticketID)
        {
            this.ticketID = ticketID;
        }

        public override void Display()
        {
            Console.WriteLine("\nDefect ------ ");
            Console.WriteLine(" Ticket ID: {0}", ticketID);
            Console.WriteLine(" Summary: {0}", ticketSummary);
            Console.WriteLine(" Status: {0}", ticketStatus);
            Console.WriteLine(" Priority: {0}", ticketPriority);
            Console.WriteLine(" Submitted by: {0}", submittedBy);
            Console.WriteLine(" Assigned to: {0}", assginedTo);
            Console.WriteLine(" Watching: {0}", watching);
            Console.WriteLine(" Severity: {0}", _severity);
        }

        public void DefectEntry()
        {
            Console.WriteLine("Enter the summary: ");
            this.ticketSummary = Console.ReadLine();
            Console.WriteLine("Enter the status: ");
            this.ticketStatus = Console.ReadLine();
            Console.WriteLine("Enter the priority: ");
            this.ticketPriority = Console.ReadLine();
            Console.WriteLine("Enter submitted by: ");
            this.submittedBy = Console.ReadLine();
            Console.WriteLine("Enter assigned to: ");
            this.assginedTo = Console.ReadLine();
            Console.WriteLine("Enter watching: ");
            this.watching = Console.ReadLine();
            Console.WriteLine("Enter the severity: ");
            this._severity = Console.ReadLine();
        }

        public override string ToString()
        {
            string str = this.ticketID + "|"
                                             + this.ticketSummary + "|"
                                             + this.ticketStatus + "|"
                                             + this.ticketPriority + "|"
                                             + this.submittedBy + "|"
                                             + this.assginedTo + "|"
                                             + this.watching + "|"
                                             + this._severity;
            return str;
        }
    }
}

