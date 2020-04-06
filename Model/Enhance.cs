using System;

namespace TicketingClasses.Model
{
    public class Enhance : Ticket
    {
        // TicketID, Summary, Status, Priority, Submitter, Assigned, Watching, Software, Cost, Reason, Estimate

        public string _software { get; set; }
        public decimal _cost { get; set; }
        public string _reason { get; set; }
        public decimal _estimate { get; set; }

        // Constructor
        public Enhance() { }
        public Enhance(int ticketID)
           { 
            this.ticketID = ticketID;
           }

        public override void Display()
        {
            Console.WriteLine("\nEnhance ------ ");
            Console.WriteLine(" Ticket ID: {0}", ticketID);
            Console.WriteLine(" Summary: {0}", ticketSummary);
            Console.WriteLine(" Status: {0}", ticketStatus);
            Console.WriteLine(" Priority: {0}", ticketPriority);
            Console.WriteLine(" Submitted by: {0}", submittedBy);
            Console.WriteLine(" Assigned to: {0}", assginedTo);
            Console.WriteLine(" Watching: {0}", watching);
            Console.WriteLine(" Software: {0}", _software);
            Console.WriteLine(" Cost: {0}", _cost);
            Console.WriteLine(" Reason: {0}", _reason);
            Console.WriteLine(" Estimate: {0}", _estimate);
        }

        public void EnhanceEntry()
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
            Console.WriteLine("Enter the software: ");
            this._software = Console.ReadLine();
            Console.WriteLine("Enter the cost $: ");
            this._cost = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the reason: ");
            this._reason = Console.ReadLine();
            Console.WriteLine("Enter the estimate $: ");
            this._estimate = Convert.ToDecimal(Console.ReadLine());
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
                                       + this._software + "|"
                                       + this._cost + "|"
                                       + this._reason + "|"
                                       + this._estimate;
            return str;
        }
    }
}


