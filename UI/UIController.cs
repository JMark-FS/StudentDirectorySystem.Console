using System;

namespace UI
{
    public static class UIController
    {
        public static int HomeDisplay()
        {
            string input;
            int command;
            do
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("\n\t_________________________________________________________________________________________");
                Console.WriteLine("\n\t|                        Welcome to Student's Registration Site                         |");
                Console.WriteLine("\n\t|                                           |                                           |");
                Console.WriteLine("\n\t|         Students Record Menu              |         Subjects Record Menu              |");
                Console.WriteLine("\n\t|                                           |                                           |");
                Console.WriteLine("\n\t|   Input 1: Create a student Record        |   Input 6: Create a subject record        |");
                Console.WriteLine("\n\t|   Input 2: Update a student Record        |   Input 7: Update a subject record        |");
                Console.WriteLine("\n\t|   Input 3: Delete a student Record        |   Input 8: Delete a subject record        |");
                Console.WriteLine("\n\t|   Input 4: Search a student Record        |   Input 9: Search a subject record        |");
                Console.WriteLine("\n\t|   Input 5: Display all student Records    |   Input 10: Display all subject records   |");
                Console.WriteLine("\n\t|_______________________________________________________________________________________|");
                Console.WriteLine("\n\t|                                                                                       |");
                Console.WriteLine("\n\t|                                       Other Menu                                      |");
                Console.WriteLine("\n\t|                                                                                       |");
                Console.WriteLine("\n\t|                       Input 11: Enroll a student to a subject                         |");
                Console.WriteLine("\n\t|                       Input 12: Drop a subject                                        |");
                Console.WriteLine("\n\t|                       Input 0: Exit the program                                       |");
                Console.WriteLine("\n\t|_______________________________________________________________________________________|");
                Console.WriteLine("\n\t\t\tProvide Input: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out command));
            return command;
            
        }

        public static int CreateStudentOptionsDisplay()
        {
            string input;
            int command;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("\n\t\t\t\t\t\t\t______________________________________");
                Console.WriteLine("\n\t\t\t\t\t\t\t|      Create student Record         |");
                Console.WriteLine("\n\t\t\t\t\t\t\t|                                    |");
                Console.WriteLine("\n\t\t\t\t\t\t\t|   Press 1: Manual Input            |");
                Console.WriteLine("\n\t\t\t\t\t\t\t|   Press 2: Read a File \".txt\"      |");
                Console.WriteLine("\n\t\t\t\t\t\t\t|   Press 0: Return to Previous Menu |");
                Console.WriteLine("\n\t\t\t\t\t\t\t|____________________________________|");
                Console.WriteLine("\n\t\t\t\t\t\t\t\tInput command: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out command));
            return command;
        }

        public static void CreateStudentRecordDisplay()
        {

        }
    }
}
