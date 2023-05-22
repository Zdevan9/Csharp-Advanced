using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using TimeTrack.MainMenu;
using static TimeTrack.DataBases.UserDB;


namespace FitApp.Login_Code
{
    public class Login
    {
        private const string UserDatabaseFilePath = "users.json";
        private UserDatabase userDatabase;
        public void LoginRegister()
        {
            userDatabase = new UserDatabase();
            Console.WriteLine("Hello! Welcome to Time Track!");
            Console.WriteLine("Do you have an account?");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");

            string input = Console.ReadLine();
            int num = int.Parse(input);

            if (num == 1)
            {
                Console.WriteLine("Enter your username:");
                string username = Console.ReadLine();
                if (userDatabase.UserExists(username))
                {
                    Console.WriteLine("Enter your password:");
                    string password = Console.ReadLine();

                    // TODO: validate password
                    //string fileContents = File.ReadAllText("users.json");
                    //Console.WriteLine(fileContents);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Welcome back {username}! You will be redirected to the Main Menu");
                    Console.ResetColor();
                    MainMenu main = new MainMenu();
                    Thread.Sleep(2000);
                    main.MainPage();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry, there is no user with the username {username}.");
                    Console.ResetColor();
                }

            }
            else
            {
                Console.WriteLine("Enter your First Name:");
                string FirstName = Console.ReadLine();
                while (true)
                {
                    if (FirstName.Length < 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your First Name cannot be shorter than two characters. Please enter a new First Name.");
                        Console.ResetColor();
                        FirstName = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("Enter your Last Name:");
                string LastName = Console.ReadLine();
                while (true)
                {
                    if (LastName.Length < 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your Last Name cannot be shorter than two characters. Please enter a new Last Name.");
                        Console.ResetColor();
                        LastName = Console.ReadLine();

                    }
                    else
                    {
                        break;
                    }
                }
                int age = 0;
                while (true)
                {
                    Console.WriteLine("How old are you?");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out age))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a valid number.");
                        Console.ResetColor();
                    }
                    else if (age < 18)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You must be above 18 to join!");
                        Console.ResetColor();
                    }
                    else if (age > 120)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You should be dead not working out!");
                        Console.ResetColor();
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("Create your username:");
                string usernameRegister = Console.ReadLine();
                while (true)
                {
                    if (usernameRegister.Length < 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your username cannot be shorter than five characters. Please enter a new username.");
                        Console.ResetColor();
                        usernameRegister = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("Create your password:");
                string passwordRegister = Console.ReadLine();
                while (true)
                {
                    if (passwordRegister.Length < 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your password cannot be shorter than six characters. Please enter a new password.");
                        Console.ResetColor();
                        passwordRegister = Console.ReadLine();
                        
                    }
                    else
                    {
                        break;
                    }
                }
                User newUser = new User
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    Age = age,
                    Username = usernameRegister,
                    Password = passwordRegister,
                };
                userDatabase.AddUser(newUser);
                userDatabase.SaveToFile();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Welcome {FirstName}! You've successfuly registered!");
                Console.WriteLine("You will now be redirected to the Main Menu");
                Console.ResetColor();
                MainMenu main = new MainMenu();
                Thread.Sleep(2000);
                main.MainPage();

            }
        }
    }
}
