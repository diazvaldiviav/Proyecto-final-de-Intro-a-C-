using System;

namespace Restaurant10TablesReservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = new string[10] {"", "", "", "", "", "", "", "", "", ""};
            int arrayCurrentIndex = 0;
            string userType;
            string exit;
            Console.WriteLine("Welcome to the best restaurant in the world!\n");

            while (arrayCurrentIndex < 10)
            {
       
                Console.WriteLine("Are you a registred user?, Write yes, or not to register or write exit to exit\n");
                userType = Console.ReadLine();
                if(userType == "yes")
                {
                    Console.WriteLine("Your are a register user, please enter your excact user name\n");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("The user you searched is {0}\n", userToSearch);
                    int index = Array.IndexOf(usernames, userToSearch);
                    if(index == -1)
                    {
                        Console.WriteLine("User not found, try again or register\n");
                    }

                    else
                    {
                        Console.WriteLine("Welcome {0}, it's a pleasure to give you food\n", usernames[index]);
                    }
                }
                if (userType == "exit")
                {
                    Console.WriteLine("Gracias por usar nuestro programa");
                    Environment.Exit(0);
                }
                else if(userType == "not"){
                    Console.WriteLine("Please write and remember your user Name\n");
                    usernames[arrayCurrentIndex] = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Your user has been save successfully" + "your user name is {0}", usernames[arrayCurrentIndex]);
                    arrayCurrentIndex++;

                } 

            }
            Console.WriteLine("The restaurant is full, try again tomorrow\n");
            int auxIndex = 0;

            foreach(string element in usernames)
            {
                Console.WriteLine("User number {0} and user name: {1}", auxIndex+1 , usernames[auxIndex]);
                auxIndex++;
            }
             
        }
    }
}
