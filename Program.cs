using System;
using System.Collections.Generic;
using System.IO;
using TicketingClasses.Model;

namespace Ticketing
{
    class Program
    {
        /* *
        * file name = tickets.csv saved at runtime to C:\Users\JerryChiu\source\repos\Ticketing\Ticketing\bin\Debug
        * TicketID, Summary, Status, Priority, Submitter, Assigned, Watching
        * 1,This is a bug ticket,Open,High,Drew Kjell, Jane Doe,Drew Kjell| John Smith | Bill Jones
        * 
        * future proof:  should introduce ArrayList ticketList = new ArrayList() to container collection of tickets
        */

        static void Main(string[] args)
        {

            //ideally should be database but using List for simplicity
            //var db = new TicketingContext();

            List<Ticket> listOfTickets = new List<Ticket>();

            // this assumes the existance of a file but does not automatically check for it
            // instead from the main menu, it prompts user
            string file = Path.Combine(Environment.CurrentDirectory, "Files", "tickets.csv");

            // start of main menu
            string choice;

            do
            {

                var menu = new Menu();
                // input response
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    FileManager fileMgr = new FileManager(file, listOfTickets);

                } // end of menu option 1 routine

                else if (choice == "2")

                {
                    // We are appending additional records on the fly to the file
                    // therefore, no need for an array to hold additional records in memory before
                    // writing to file

                    string resp;  // to capture user responses

                    do
                    {
                        // ask a question
                        Console.WriteLine("Enter a ticket (Y/N)?");
                        // input the response
                        resp = Console.ReadLine().ToUpper();
                        // if the response is anything other than "Y", stop asking
                        if (resp != "Y") { break; }

                        //prompt for ticketID

                        int currentMaxID = listOfTickets.Count;

                        int ticketID = currentMaxID + 2;

                        Console.WriteLine($"Creating a new ticket under Ticket ID : {ticketID}");

                        // prompt for ticket summary
                        Console.WriteLine("Enter ticket summary: ");
                        // save the ticket summary to variable
                        string ticketSummary = Console.ReadLine();

                        // prompt for ticket status
                        Console.WriteLine("Enter ticket status: ");
                        // save the ticket status to variable
                        string ticketStatus = Console.ReadLine();

                        // prompt for ticket priority
                        Console.WriteLine("Enter ticket priority: ");
                        // save the ticket status to variable
                        string ticketPriority = Console.ReadLine();

                        // prompt for submittedBy
                        Console.WriteLine("Enter ticket submitter's full name: ");
                        // save the ticket status to variable
                        string submittedBy = Console.ReadLine();

                        // prompt for assginedto
                        Console.WriteLine("Enter full name ticket is to be assigned: ");
                        // save the ticket status to variable
                        string assginedTo = Console.ReadLine();

                        // prompt for watching
                        Console.WriteLine("Enter full name of person watching ticket: ");
                        // save the ticket status to variable
                        string watching = Console.ReadLine();

                        // *TicketID, Summary, Status, Priority, Submitter, Assigned, Watching
                        // 1,This is a bug ticket,Open,High,Drew Kjell, Jane Doe,Drew Kjell| John Smith | Bill Jones*/

                        StreamWriter sw = new StreamWriter(file, append: true);

                        sw.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}",
                            ticketID, ticketSummary, ticketStatus, ticketPriority, submittedBy, assginedTo, watching);

                        sw.Close();

                    } while (resp != "N"); // do while loop for option 2 to continue adding records

                }
            } while (choice == "1" || choice == "2");  // do while loop for main menu; any other option exits

        }

    }
}

