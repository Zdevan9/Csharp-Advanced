using Newtonsoft.Json;
using TimeTrack.DataBases;
using TimeTrack.Models;

namespace TimeTrack.Models
{
    internal class Statistics
    {
        public void UserStatistics()
        {
            Console.WriteLine("Which statistic would you like to check?");
            Console.WriteLine("1. Reading");
            Console.WriteLine("2. Exercising");
            Console.WriteLine("3. Working");
            Console.WriteLine("4. Back");

            int input = 0;
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.ForegroundColor = ConsoleColor.Red;  
                Console.WriteLine("Please enter a valid number");
                Console.ResetColor();
            }
            else if (input < 1 ||  input > 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a number between 1 and 3");
                Console.ResetColor();
            }
            switch (input)
            {
                case 1:
                    string json1 = File.ReadAllText("users.json");
                    List<UserDB.User> users1 = JsonConvert.DeserializeObject<List<UserDB.User>>(json1);
                    string username1 = Environment.UserName;
                    UserDB.User currentUser1 = users1.Find(u => u.Username == username1);
                    Console.WriteLine("Total time spent on reading: " + currentUser1.ElapsedTimeReading);
                    break;

                case 2:
                    string json2 = File.ReadAllText("users.json");
                    List<UserDB.User> users = JsonConvert.DeserializeObject<List<UserDB.User>>(json2);
                    string username2 = Environment.UserName;
                    UserDB.User currentUser2 = users.Find(u => u.Username == username2);
                    Console.WriteLine("Total time spent on exercising: " + currentUser2.ElapsedTimeExercising);
                    break;

                case 3:
                    string json3 = File.ReadAllText("users.json");
                    List<UserDB.User> users3 = JsonConvert.DeserializeObject<List<UserDB.User>>(json3);
                    string username3 = Environment.UserName;
                    UserDB.User currentUser3 = users3.Find(u => u.Username == username3);
                    Console.WriteLine("Total time spent on working: " + currentUser3.ElapsedTimeWorking);
                    break;
                case 4:
                    Back back = new Back();
                    back.BackButton();
                    break;

            }
        }
    }
}
