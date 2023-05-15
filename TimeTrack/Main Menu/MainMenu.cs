using TimeTrack.Models;

namespace TimeTrack.MainMenu
{
    public class MainMenu
    {
        public void MainPage()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Track");
            Console.WriteLine("2. Statistics");
            Console.WriteLine("3. Account Management");
            Console.WriteLine("4. Log Out");

            int option = 0;

            while (true)
            {
                Console.Write("Enter option number: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out option))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option. Please enter a number.");
                    Console.ResetColor();
                }
                else if (option < 1 || option > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 5.");
                    Console.ResetColor();
                }
                else
                {
                    break;
                }
            }

            switch (option)
            {
                case 1:
                    Track track = new Track();
                    track.Tracking();
                    break;
                case 2:
                    Statistics stat = new Statistics();
                    stat.UserStatistics();
                    break;
                case 3:
                    AccManagement management = new AccManagement();
                    management.Management();
                    break;
                case 4:
                    LogOut logout = new LogOut();
                    logout.Logout();
                    break;
            }
        }
    }
}
