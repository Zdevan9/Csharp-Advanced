using Newtonsoft.Json;
using TimeTrack.DataBases;
using static TimeTrack.DataBases.UserDB;

namespace TimeTrack.Models
{
    internal class AccManagement
    {
        public void Management()
        {
            Console.WriteLine("1. Change password");
            Console.WriteLine("2. Change First Name");
            Console.WriteLine("3. Change Last Name");
            Console.WriteLine("4. Back");    

            int input = 0;
            while (true)
            {
                string chosenOption = Console.ReadLine();
                if (!int.TryParse(chosenOption, out input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number");
                    Console.ResetColor();
                } else if (input < 1 || input > 4 )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number between 1 and 3");
                    Console.ResetColor();  
                }else { break; }
            }
            switch (input)
            {
                case 1:
                    string json1 = File.ReadAllText("users.json");
                    List<UserDB.User> users1 = JsonConvert.DeserializeObject<List<UserDB.User>>(json1);
                    string username1 = Environment.UserName;
                    UserDB.User currentUser1 = users1.Find(u => u.Username == username1);
                    Console.WriteLine("Your current password is: " + currentUser1.Password);
                    Console.WriteLine("Enter the password you want to change it to:");
                    string newpassword = Console.ReadLine();
                    currentUser1.Password = newpassword;
                    string updatedJson = JsonConvert.SerializeObject(users1, Formatting.Indented);
                    File.WriteAllText("users.json", updatedJson);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You sucesfully changed the password to: {newpassword}");
                    Console.ResetColor();
                    break;

                case 2:
                    string json2 = File.ReadAllText("users.json");
                    List<UserDB.User> users2 = JsonConvert.DeserializeObject<List<UserDB.User>>(json2);
                    string username2 = Environment.UserName;
                    UserDB.User currentUser2 = users2.Find(u => u.Username == username2);
                    Console.WriteLine("Your current First Name is: " + currentUser2.FirstName);
                    Console.WriteLine("Enter the First Name you want to change it to:");
                    string firstname = Console.ReadLine();
                    currentUser2.FirstName = firstname;
                    string updatedJson2 = JsonConvert.SerializeObject(users2, Formatting.Indented);
                    File.WriteAllText("users.json", updatedJson2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You sucesfully changed the First Name to: {firstname}");
                    Console.ResetColor();
                    break;

                case 3:
                    string json3 = File.ReadAllText("users.json");
                    List<UserDB.User> users3 = JsonConvert.DeserializeObject<List<UserDB.User>>(json3);
                    string username3 = Environment.UserName;
                    UserDB.User currentUser3 = users3.Find(u => u.Username == username3);
                    Console.WriteLine("Your current Last Name is: " + currentUser3.LastName);
                    Console.WriteLine("Enter the Last Name you want to change it to:");
                    string lastname = Console.ReadLine();
                    currentUser3.LastName = lastname;
                    string updatedJson3 = JsonConvert.SerializeObject(users3, Formatting.Indented);
                    File.WriteAllText("users.json", updatedJson3);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You sucesfully changed the Last Name to: {lastname}");
                    Console.ResetColor();
                    break;
                case 4:
                    Back back = new Back();
                    back.BackButton();
                    break;
            }
        }
    }
}
