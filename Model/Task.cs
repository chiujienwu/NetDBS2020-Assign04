using System;

namespace TicketingClasses.Model
{
    public class Task : Ticket
    {
        //TicketID, Summary, Status, Priority, Submitter, Assigned, Watching, ProjectName, DueDate
        public string _projectName { get; set; }
        public DateTime _dueDate { get; set; }

        // Constructor
        public Task() { }
        public Task(int ticketID)
        {
            this.ticketID = ticketID;
        }

        public override void Display()
        {
            Console.WriteLine("\nTask ------ ");
            Console.WriteLine(" Ticket ID: {0}", ticketID);
            Console.WriteLine(" Summary: {0}", ticketSummary);
            Console.WriteLine(" Status: {0}", ticketStatus);
            Console.WriteLine(" Priority: {0}", ticketPriority);
            Console.WriteLine(" Submitted by: {0}", submittedBy);
            Console.WriteLine(" Assigned to: {0}", assginedTo);
            Console.WriteLine(" Watching: {0}", watching);
            Console.WriteLine(" Project Name: {0}", _projectName);
            Console.WriteLine(" Due Date: {0}", _dueDate);
        }

        public void TaskEntry()
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
            Console.WriteLine("Enter the project name: ");
            this._projectName = Console.ReadLine();
            Console.WriteLine("Enter the due date: ");
            this._dueDate = Convert.ToDateTime(Console.ReadLine());
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
                                       + this._projectName + "|"
                                       + this._dueDate;
            return str;
        }
    }
}
