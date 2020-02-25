using System;
using System.Collections.Generic;
using System.IO;


namespace Ticketing
{
    class FileManager

    {
        public FileManager(string file, List<Ticket> listOfTickets)
        {
            if (File.Exists(file))
            {
                // read data from file
                StreamReader sr = new StreamReader(file);
                while (!sr.EndOfStream)
                {
                    //start to read data file
                    string line = sr.ReadLine();
                    // convert string to array
                    string[] arr = line.Split('|');

                    // display to console array data from file
                    // array index: 0-TicketID, 1-Summary, 2-Status, 3-Priority, 4-Submitter, 5-Assigned, 6-Watching
                    Console.WriteLine("TicketID: {0}, Summary: {1}, Status: {2}, Priority: {3}, Submitter: {4}, Assigned: {5}, Watching: {6},",
                        arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);

                    int readID = Convert.ToInt32(arr[0]);

                    var anotherTicket = new Ticket() { ticketID = readID, ticketSummary = arr[1], ticketStatus = arr[2], ticketPriority = arr[3], submittedBy = arr[4], assginedTo = arr[5], watching = arr[6] };

                    listOfTickets.Add(anotherTicket);

                    for (int i = 0; i < listOfTickets.Count; i++)
                    {
                        Console.WriteLine(listOfTickets[i].ticketID);
                    }

                    //if (readID > maxID) { maxID = readID; }

                    //ticketCount = ticketCount++;
                }
                sr.Close();
            }
            else
            {
                Console.WriteLine("File does not exist");
                Console.WriteLine("Creating an empty file");
                StreamWriter sw = new StreamWriter(file);
                //ticketCount = 0;
                sw.Close();
            }
        }
    }
}

