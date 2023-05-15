using FitApp.Login_Code;
using TimeTrack.MainMenu;

namespace TimeTrack.Models
{
    public class LogOut
    {
        public void Logout() 
        {
            Console.WriteLine("Are you sure you want to log out? Y/N");
            string input = Console.ReadLine();

            while (true)
            {
                if (input == null)
                {
                    Console.WriteLine("Please enter a 'y' or 'n'");
                }
                else if (input.ToLower() != "y" && input.ToLower() != "n")
                {
                    Console.WriteLine("Invalid input please enter a 'y' or 'n'");
                }
                else { break; }
                input = Console.ReadLine();

            }
            switch (input)
            {
                case "y": Login main = new Login();
                    main.LoginRegister();
                    break;
                
                case "n":
                    MainMenu.MainMenu mainMenu = new MainMenu.MainMenu();
                    mainMenu.MainPage();
                    break;
            }

            
        }
    }
}
