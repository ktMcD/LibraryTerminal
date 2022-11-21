using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminal
{
    public static class Navigation
    {
        public static bool TryAgain(string theError)
        {
            bool tryAgain;
            string libraryPatronResponse;
            switch (theError)
            {
                case "invalid entry":
                    Communication.TalkToUser("Menu selections should only be entered as  alpha-numeric characters");
                    break;
                default:
                    break;
            }
            Communication.TalkToUser("Would you like to select another menu item?");
            Communication.TalkToUser("Enter \"y\" or \"yes\" to try again; anything else to quit");
            libraryPatronResponse = Communication.ListenToUser();
            if (libraryPatronResponse.ToLower() != "y" && libraryPatronResponse.ToLower() != "yes")
            {
                return false;
            }
            return true;
        }

        public static void ThankYouAndGoodbye()
        {
            Communication.TalkToUser("Thank you for visiting Library Console today.");
            Communication.TalkToUser("Please come back another time.");
            
            Console.WriteLine();
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
