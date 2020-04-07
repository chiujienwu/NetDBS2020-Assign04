using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TicketingClasses.Model;

namespace Ticketing
/*
 * Assignment #5
 * Modify your Ticket system application - add support for different Ticket Types
 *  Bug/Defect
 *  Enhancement
 *  Task
 *
 * Tickets.csv
 * TicketID, Summary, Status, Priority, Submitter, Assigned, Watching, Severity
 *
 * Enhancements.csv
 * TicketID, Summary, Status, Priority, Submitter, Assigned, Watching, Software, Cost, Reason, Estimate
 *
 * Task.csv
 * TicketID, Summary, Status, Priority, Submitter, Assigned, Watching, ProjectName, DueDate
 *
 * ======================================================================================
 *
 * Assignment #6
 *
 * Add search to the Ticket System Application
 * User should be able to perform a search based on status, priority or submitter
 * The search results should display the results and the number of matches
 * One single search should be return results from all ticket types (Concatenation Operator)
 *
 */

{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;
            List<Defect> defectList = new List<Defect>();
            List<Enhance> enhanceList = new List<Enhance>();
            List<Task> taskList = new List<Task>();

            string defectFile = Path.Combine(Environment.CurrentDirectory, "Files", "tickets.csv");
            string enhanceFile = Path.Combine(Environment.CurrentDirectory, "Files", "enhance.csv");
            string taskFile = Path.Combine(Environment.CurrentDirectory, "Files", "task.csv");
            
            do
            {
                var menu = new Menu();
                choice = menu.GetUserInput();

                switch (choice)
                {
                    case '1':  // read defect file
                        Console.WriteLine("Menu choice 1 selected");

                        if (File.Exists(defectFile))
                        {
                            // read data from file for Defects (Tickets)
                            StreamReader sr = new StreamReader(defectFile);
                            while (!sr.EndOfStream)
                            {
                                //start to read data file
                                string line = sr.ReadLine();
                                // convert string to array
                                string[] arr = line.Split('|');

                                // display to console array data from file
                                // array index: 0-TicketID, 1-Summary, 2-Status, 3-Priority, 4-Submitter, 5-Assigned, 6-Watching, 7-Severity
                                Console.WriteLine(
                                    "TicketID: {0}, Summary: {1}, Status: {2}, Priority: {3}, Submitter: {4}, Assigned: {5}, Watching: {6}, Severity: {7}",
                                    arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7]);

                                Defect readDefect = new Defect()
                                {
                                    ticketID = Convert.ToInt32(arr[0]), ticketSummary = arr[1], ticketStatus = arr[2],
                                    ticketPriority = arr[3], submittedBy = arr[4], assginedTo = arr[5],
                                    watching = arr[6], _severity = arr[7]
                                };

                                defectList.Add(readDefect);
                            }
                            sr.Close();
                        }
                        else
                        {
                            Console.WriteLine("File does not exist");
                        }

                        break;
                    case '2':  // read data from file for Enhancements
                        Console.WriteLine("Menu choice 2 selected");

                        if (File.Exists(enhanceFile))
                        {
                            // read data from file
                            StreamReader sr = new StreamReader(enhanceFile);
                            while (!sr.EndOfStream)
                            {
                                //start to read data file
                                string line = sr.ReadLine();
                                // convert string to array
                                string[] arr = line.Split('|');

                                // display to console array data from file
                                // array index: 0-TicketID, 1-Summary, 2-Status, 3-Priority, 4-Submitter, 5-Assigned, 6-Watching, 7-Software, 8-Cost, 9-Reason, 10-Estimate
                                Console.WriteLine(
                                    "TicketID: {0}, Summary: {1}, Status: {2}, Priority: {3}, Submitter: {4}, Assigned: {5}, Watching: {6}, Software: {7}, Cost: {8}, Reason: {9}, Estimate: {10}",
                                    arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8], arr[9], arr[10]);

                                Enhance readEnhance = new Enhance()
                                {
                                    ticketID = Convert.ToInt32(arr[0]),
                                    ticketSummary = arr[1],
                                    ticketStatus = arr[2],
                                    ticketPriority = arr[3],
                                    submittedBy = arr[4],
                                    assginedTo = arr[5],
                                    watching = arr[6],
                                    _software = arr[7],
                                    _cost = Convert.ToDecimal(arr[8]),
                                    _reason = arr[9],
                                    _estimate = Convert.ToDecimal(arr[10])
                                };

                                enhanceList.Add(readEnhance);
                            }
                            sr.Close();
                        }
                        else
                        {
                            Console.WriteLine("File does not exist");
                        }

                        break;
                    case '3':  // read data from file for Tasks
                        Console.WriteLine("Menu choice 3 selected");

                        if (File.Exists(taskFile))
                        {
                            // read data from file
                            StreamReader sr = new StreamReader(taskFile);
                            while (!sr.EndOfStream)
                            {
                                //start to read data file
                                string line = sr.ReadLine();
                                // convert string to array
                                string[] arr = line.Split('|');

                                // display to console array data from file
                                // array index: 0-TicketID, 1-Summary, 2-Status, 3-Priority, 4-Submitter, 5-Assigned, 6-Watching, 7-Project Name, 8-Due Date
                                Console.WriteLine(
                                    "TicketID: {0}, Summary: {1}, Status: {2}, Priority: {3}, Submitter: {4}, Assigned: {5}, Watching: {6}, Project Name: {7}, Due Date: {8}",
                                    arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8]);

                                Task readTask = new Task()
                                {
                                    ticketID = Convert.ToInt32(arr[0]),
                                    ticketSummary = arr[1],
                                    ticketStatus = arr[2],
                                    ticketPriority = arr[3],
                                    submittedBy = arr[4],
                                    assginedTo = arr[5],
                                    watching = arr[6],
                                    _projectName = arr[7],
                                    _dueDate = Convert.ToDateTime(arr[8])
                                };

                                taskList.Add(readTask);
                            }
                            sr.Close();
                        }
                        else
                        {
                            Console.WriteLine("File does not exist");
                        }

                        break;
                    case '4':  // create defect
                        Console.WriteLine("Menu choice 4 selected");

                        int defectCount = defectList.Count + 1;
                        Defect newDefect = new Defect(defectCount);
                        newDefect.DefectEntry();
                        newDefect.Display();
                        defectList.Add(newDefect);
                        Console.WriteLine(defectList.Count);

                        break;
                    case '5':  // create enhancement
                        Console.WriteLine("Menu choice 5 selected");

                        int enhanceCount = enhanceList.Count + 1;
                        Enhance newEnhance = new Enhance(enhanceCount);
                        newEnhance.EnhanceEntry();
                        newEnhance.Display();
                        enhanceList.Add(newEnhance);
                        Console.WriteLine(enhanceList.Count);

                        break;
                    case '6':  // create tasks
                        Console.WriteLine("Menu choice 6 selected");

                        int taskCount = taskList.Count + 1;
                        Task newTask = new Task(taskCount);
                        newTask.TaskEntry();
                        newTask.Display();
                        taskList.Add(newTask);
                        Console.WriteLine(taskList.Count);

                        break;
                    case '7':
                        Console.WriteLine("Menu choice 7 selected");

                        if (File.Exists(defectFile))
                        {
                            try
                            {
                                Console.WriteLine("Appending to existing defect file...");
                                StreamWriter sw = new StreamWriter(defectFile, append: true);
                                foreach (var defectItem in defectList)
                                {
                                    string str = defectItem.ToString();
                                    sw.WriteLine(str);
                                }
                                sw.Close();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                throw;
                            }
                        }
                        else
                        {
                            Console.WriteLine("File does not exist.  Creating defect file...");
                            StreamWriter sw = new StreamWriter(defectFile);
                            foreach (var defectItem in defectList)
                            {
                                string str = defectItem.ToString();
                                sw.WriteLine(str);
                            }
                            sw.Close();
                        }

                        break;
                    case '8':
                        Console.WriteLine("Menu choice 8 selected");

                        if (File.Exists(enhanceFile))
                        {
                            try
                            {
                                Console.WriteLine("Appending to existing defect file...");
                                StreamWriter sw = new StreamWriter(enhanceFile, append: true);
                                foreach (var enhanceItem in enhanceList)
                                {
                                    string str = enhanceItem.ToString();
                                    sw.WriteLine(str);
                                }
                                sw.Close();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                throw;
                            }
                        }
                        else
                        {
                            Console.WriteLine("File does not exist.  Creating defect file...");
                            StreamWriter sw = new StreamWriter(enhanceFile);
                            foreach (var enhanceItem in enhanceList)
                            {
                                string str = enhanceItem.ToString();
                                sw.WriteLine(str);
                            }
                            sw.Close();
                        }

                        break;
                    case '9':
                        Console.WriteLine("Menu choice 9 selected");

                        if (File.Exists(taskFile))
                        {
                            try
                            {
                                Console.WriteLine("Appending to existing defect file...");
                                StreamWriter sw = new StreamWriter(taskFile, append: true);
                                foreach (var taskItem in taskList)
                                {
                                    string str = taskItem.ToString();
                                    sw.WriteLine(str);
                                }
                                sw.Close();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                throw;
                            }
                        }
                        else
                        {
                            Console.WriteLine("File does not exist.  Creating defect file...");
                            StreamWriter sw = new StreamWriter(taskFile);
                            foreach (var taskItem in taskList)
                            {
                                string str = taskItem.ToString();
                                sw.WriteLine(str);
                            }
                            sw.Close();
                        }

                        break;
                }
            } while (choice != '0');

        }
    }
}

