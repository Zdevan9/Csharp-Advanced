using Newtonsoft.Json;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using TimeTrack.DataBases;
using TimeTrack.MainMenu;


namespace TimeTrack.Models
{
    public class Track
    {
        private static Hobbies hobbies = new Hobbies();
        public void Tracking() 
        {
            Console.WriteLine("Welcome to Tracking what activity would you like to choose?");
            Console.WriteLine("1. Reading");
            Console.WriteLine("2. Exercising");
            Console.WriteLine("3. Working");
            Console.WriteLine("4. Hobbies");
            Console.WriteLine("5. Back");

            int input = 0;
            while (true) 
            {
                string chosenOption= Console.ReadLine();

                if (!int.TryParse(chosenOption, out input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option. Please enter a number.");
                    Console.ResetColor();
                }
                else if (input < 1 || input > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 3.");
                    Console.ResetColor();
                }
                else
                {
                    break;
                }
            }

// Reading option selected
            switch (input)
            {
                case 1:
                    Console.WriteLine("Welcome to the reading section");
                    Console.WriteLine("What reading activity would you like to track?");
                    Console.WriteLine("1. Belles Lettres");
                    Console.WriteLine("2. Fiction");
                    Console.WriteLine("3. Professional Literature");

                    int inputReading = 0;
                    while (true) 
                    {
                        string chosenOptionReading = Console.ReadLine();
                        if(!int.TryParse(chosenOptionReading, out inputReading)) 
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option. Please enter a number.");
                            Console.ResetColor();
                        }
                        else if (inputReading < 1 || inputReading > 3)  
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option. Please enter a number between 1 and 3.");
                            Console.ResetColor();
                        }
                        else { break; }
                    }
                    switch (inputReading) 
                    {
                        case 1:
                            string username = Environment.UserName;
                            TimeTracker reading1 = new TimeTracker(username);
                            reading1.BellesLettres();
                            break;
                        case 2:
                            Console.WriteLine("The system will now start to track the Fiction activity");
                            string username1 = Environment.UserName;
                            TimeTracker reading2 = new TimeTracker(username1);
                            reading2.Fiction();
                            break;
                        case 3:
                            Console.WriteLine("The system will now start to track the Professional Literature activity");
                            string username2 = Environment.UserName;
                            TimeTracker reading3 = new TimeTracker(username2);
                            reading3.ProfessionalLiterature();
                            break;
                    }
                    break;

// Exercising option selected
                case 2:
                    Console.WriteLine("Welcome to the exercising section");
                    Console.WriteLine("What reading activity would you like to track?");
                    Console.WriteLine("1. General Exercise");
                    Console.WriteLine("2. Running");
                    Console.WriteLine("3. Sport");

                    int exerciseInput = 0;
                    while (true)
                    {
                        string chosenOptionExercise = Console.ReadLine();
                        if (!int.TryParse(chosenOptionExercise, out exerciseInput))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter a valid number");
                            Console.ResetColor();
                        }
                        else if (exerciseInput < 1 || exerciseInput > 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option. Please enter a number between 1 and 3.");
                            Console.ResetColor();
                        }
                        else { break; }
                    }
                    switch (exerciseInput)
                    {
                        case 1:
                            Console.WriteLine("The system will now start to track the General activity");
                            string username = Environment.UserName;
                            TimeTracker exercise1 = new TimeTracker(username);
                            exercise1.GeneralExercise();                                                   
                            break;
                        case 2:
                            Console.WriteLine("The system will now start to track the Running activity");
                            string username1 = Environment.UserName;
                            TimeTracker exercise2 = new TimeTracker(username1);
                            exercise2.Running();
                            break;
                        case 3:
                            Console.WriteLine("The system will now start to track the Sport activity");
                            string username2 = Environment.UserName;
                            TimeTracker exercise3 = new TimeTracker(username2);
                            exercise3.Sport();
                            break;
                    }
                    break;


// Working option selected
                case 3:
                    Console.WriteLine("Welcome to the working section");
                    Console.WriteLine("What reading activity would you like to track?");
                    Console.WriteLine("1. Work From the Office");
                    Console.WriteLine("2. Work from Home");

                    int workingInput = 0;
                    while (true)
                    {
                        string chosenWorkingInput = Console.ReadLine();
                        if(!int.TryParse(chosenWorkingInput, out workingInput))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter a valid number");
                            Console.ResetColor();
                        }else if (workingInput < 1 || workingInput > 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option. Please enter a number between 1 and 2.");
                            Console.ResetColor();
                        }else { break; }
                    }
                    switch (workingInput)
                    {
                        case 1:
                            Console.WriteLine("The system will now start to track the Working From Office activity");
                            string username = Environment.UserName;
                            TimeTracker working = new TimeTracker(username);
                            working.WorkingFromOffice();                            
                            break;
                        case 2:
                            Console.WriteLine("The system will now start to track the Working From Home activity");
                            string username1 = Environment.UserName;
                            TimeTracker working1 = new TimeTracker(username1);
                            working1.WorkingFromHome();                            
                            break;
                    }
                    break;

// Hobbies option selected 
                case 4:
                    
                    Console.WriteLine("Welcome to the hobbies section");
                    Console.WriteLine("What hobby would you like to track?");
                    if(hobbies.Count == 0)
                    {
                        
                        Console.WriteLine("The hobbies list is empty.");
                        Console.WriteLine("Would you like to create a new hobby? Y/N");
                        string hobbiesInput = Console.ReadLine();
                        if(hobbiesInput.ToLower() == "y")
                        {
                            Console.WriteLine("What's the name of the new hobby?");
                            string newhobby = Console.ReadLine();
                            hobbies.AddHobby(newhobby);
                            MainMenu.MainMenu main1 = new MainMenu.MainMenu();
                            main1.MainPage();

                        }
                        else if (hobbiesInput.ToLower() == "n")
                        {
                            Console.WriteLine("The system will redirect you to the Main Menu");
                            Thread.Sleep(2000);
                            MainMenu.MainMenu main = new MainMenu.MainMenu();
                            main.MainPage();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your hobbies:");
                        foreach (string hobby in hobbies.GetHobbies())
                        {
                            Console.WriteLine(hobby);
                            Console.WriteLine("Would you like to track the hobby? Y/N");
                            string trackHobby = Console.ReadLine();
                            if (trackHobby.ToLower() == "y")
                            {
                                Console.WriteLine("The hobby activity is now tracked!");
                                TimeTracker hobby1 = new TimeTracker("");
                                //hobby1.Start();

                            }
                            else if (trackHobby.ToLower()== "n")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You will be redirected to the Main Menu!");
                                MainMenu.MainMenu main = new MainMenu.MainMenu();
                                Thread.Sleep(2000);
                                main.MainPage();
                            }
                        }
                    }
                    break;
                case 5:
                    Back back = new Back();
                    back.BackButton();
                    break;
                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }
        }
    }
}
