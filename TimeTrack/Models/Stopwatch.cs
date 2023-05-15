using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using TimeTrack.DataBases;
using static TimeTrack.DataBases.UserDB;

namespace TimeTrack.Models
{
    public class TimeTracker
    {
        public string username;
        public UserDB.UserDatabase userDatabase;
        public Stopwatch stopwatch;

        public TimeTracker(string username)
        {
            this.username = username;
            this.userDatabase = new UserDB.UserDatabase();
            this.stopwatch = new Stopwatch();
        }
        public void BellesLettres()
        {
            Console.WriteLine("Timer started. Press any key to stop.");
            this.stopwatch.Start();
            while (true)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {                    
                    TimeSpan elapsed = this.stopwatch.Elapsed;
                    this.stopwatch.Stop();
                    Console.WriteLine($"\nElapsed time this session {elapsed}");
                    UserDB.UserDatabase userDatabase = new UserDB.UserDatabase();
                    UserDB.User currentUser = userDatabase.GetUser(this.username);
                    if (currentUser != null)
                    {
                        currentUser.BellesLettres = currentUser.BellesLettres.Add(elapsed);
                        userDatabase.SaveUser(currentUser);
                        Console.WriteLine("Total time spent on Belles Lettres: " + currentUser.BellesLettres);
                        currentUser.ElapsedTimeReading = currentUser.ElapsedTimeReading.Add(elapsed);
                        userDatabase.SaveUser(currentUser);
                        Console.WriteLine("Total time spent on Reading: " + currentUser.ElapsedTimeReading);

                    }
                    else
                    {
                        Console.WriteLine($"User {this.username} does not exist in the database.");
                    }
                    break;
                }                
                Console.CursorLeft = 0;
                Console.Write(this.stopwatch.Elapsed);
            }
        }
        public void Fiction()
        {
            this.stopwatch.Start();
            while (true)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    TimeSpan elapsed = this.stopwatch.Elapsed;
                    this.stopwatch.Stop();
                    Console.WriteLine($"\nElapsed time this session {elapsed}");
                    UserDB.UserDatabase userDatabase = new UserDB.UserDatabase();
                    UserDB.User currentUser = userDatabase.GetUser(this.username);
                    if (currentUser != null)
                    {
                        currentUser.Fiction = currentUser.Fiction.Add(elapsed);
                        userDatabase.SaveUser(currentUser);
                        Console.WriteLine("Total time spent on Fiction: " + currentUser.Fiction);
                        currentUser.ElapsedTimeReading = currentUser.ElapsedTimeReading.Add(elapsed);
                        userDatabase.SaveUser(currentUser);
                        Console.WriteLine("Total time spent on Reading: " + currentUser.ElapsedTimeReading);

                    }
                    else
                    {
                        Console.WriteLine($"User {this.username} does not exist in the database.");
                    }
                    break;
                }
                Console.CursorLeft = 0;
                Console.Write(this.stopwatch.Elapsed);
            }
        }
        public void ProfessionalLiterature()
        {
            Console.WriteLine("Timer started. Press any key to stop.");
            this.stopwatch.Start();
            while (true)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    TimeSpan elapsed = this.stopwatch.Elapsed;
                    this.stopwatch.Stop();
                    Console.WriteLine($"\nElapsed time this session {elapsed}");
                    UserDB.UserDatabase userDatabase = new UserDB.UserDatabase();
                    UserDB.User currentUser = userDatabase.GetUser(this.username);
                    if (currentUser != null)
                    {
                        currentUser.ProfessionalLiterature = currentUser.ProfessionalLiterature.Add(elapsed);
                        userDatabase.SaveUser(currentUser);
                        Console.WriteLine("Total time spent on Professional Literature: " + currentUser.ProfessionalLiterature);
                        currentUser.ElapsedTimeReading = currentUser.ElapsedTimeReading.Add(elapsed);
                        userDatabase.SaveUser(currentUser);
                        Console.WriteLine("Total time spent on Reading: " + currentUser.ElapsedTimeReading);

                    }
                    else
                    {
                        Console.WriteLine($"User {this.username} does not exist in the database.");
                    }
                    break;
                }
                Console.CursorLeft = 0;
                Console.Write(this.stopwatch.Elapsed);
            }
        }
        public void GeneralExercise()
        {            
            this.stopwatch.Start();
            while (true)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    TimeSpan elapsed = this.stopwatch.Elapsed;
                    this.stopwatch.Stop();
                    Console.WriteLine($"\nElapsed time this session {elapsed}");
                    UserDB.UserDatabase userDatabase = new UserDB.UserDatabase();
                    UserDB.User currentUser = userDatabase.GetUser(this.username);
                    if (currentUser != null)
                    {
                        currentUser.GeneralExercise = currentUser.GeneralExercise.Add(elapsed);
                        userDatabase.SaveUser(currentUser);
                        Console.WriteLine("Total time spent on General Exercise: " + currentUser.GeneralExercise);
                        currentUser.ElapsedTimeExercising = currentUser.ElapsedTimeExercising.Add(elapsed);
                        userDatabase.SaveUser(currentUser);
                        Console.WriteLine("Total time spent on Exercising: " + currentUser.ElapsedTimeExercising);
                    }
                    else
                    {
                        Console.WriteLine($"User {this.username} does not exist in the database.");
                    }
                    break;
                }
                Console.CursorLeft = 0;
                Console.Write(this.stopwatch.Elapsed);
            }
        }
        
        public void Running()
        {
            this.stopwatch.Start();
            while (true)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    TimeSpan elapsed = this.stopwatch.Elapsed;
                    this.stopwatch.Stop();
                    Console.WriteLine($"\nElapsed time this session {elapsed}");    
                    UserDB.UserDatabase userDatabase = new UserDB.UserDatabase();
                    UserDB.User currentUser = userDatabase.GetUser(this.username);
                    if (currentUser != null)
                    {
                        currentUser.Running = currentUser.Running.Add(elapsed);
                        userDatabase.SaveUser(currentUser);
                        Console.WriteLine("Total time spent on Running: " + currentUser.Running);
                        currentUser.ElapsedTimeExercising = currentUser.ElapsedTimeExercising.Add(elapsed);
                        userDatabase.SaveUser(currentUser);
                        Console.WriteLine("Total time spent on Exercising: " + currentUser.ElapsedTimeExercising);
                    }
                    else
                    {
                        Console.WriteLine($"User {this.username} does not exist in the database.");
                    }
                    break;
                }
                Console.CursorLeft = 0;
                Console.Write(this.stopwatch.Elapsed);
            }
        }
        
        public void Sport()
        {
            this.stopwatch.Start();
            while (true)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    TimeSpan elapsed = this.stopwatch.Elapsed;
                    this.stopwatch.Stop();
                    Console.WriteLine($"\nElapsed time this session {elapsed}");
                    UserDB.UserDatabase userDatabase = new UserDB.UserDatabase();
                    UserDB.User currentUser = userDatabase.GetUser(this.username);
                    if (currentUser != null)
                    {
                        currentUser.Sport = currentUser.Sport.Add(elapsed);
                        userDatabase.SaveUser(currentUser);
                        Console.WriteLine("Total time spent on Sport: " + currentUser.Sport);
                        currentUser.ElapsedTimeExercising = currentUser.ElapsedTimeExercising.Add(elapsed);
                        userDatabase.SaveUser(currentUser);
                        Console.WriteLine("Total time spent on Exercising: " + currentUser.ElapsedTimeExercising);
                    }
                    else
                    {
                        Console.WriteLine($"User {this.username} does not exist in the database.");
                    }
                    break;
                }
                Console.CursorLeft = 0;
                Console.Write(this.stopwatch.Elapsed);
            }
        }
        public void WorkingFromOffice()
        {
            this.stopwatch.Start();
            while (true)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    TimeSpan elapsed = this.stopwatch.Elapsed;
                    this.stopwatch.Stop();
                    Console.WriteLine($"\nElapsed time this session {elapsed}");
                    UserDB.UserDatabase userDatabase = new UserDB.UserDatabase();
                    UserDB.User currentUser = userDatabase.GetUser(this.username);
                    if (currentUser != null)
                    {
                        currentUser.WorkingFromOffice = currentUser.WorkingFromOffice.Add(elapsed);
                        userDatabase.SaveUser(currentUser);
                        Console.WriteLine("Total time spent on Working from the office: " + currentUser.WorkingFromOffice);
                        currentUser.ElapsedTimeWorking = currentUser.ElapsedTimeWorking.Add(elapsed);
                        userDatabase.SaveUser(currentUser);
                        Console.WriteLine("Total time spent on Working: " + currentUser.ElapsedTimeWorking);

                    }
                    else
                    {
                        Console.WriteLine($"User {this.username} does not exist in the database.");
                    }
                    break;
                }
                Console.CursorLeft = 0;
                Console.Write(this.stopwatch.Elapsed);
            }
        }
        public void WorkingFromHome()
        {            
            this.stopwatch.Start();
            while (true)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    TimeSpan elapsed = this.stopwatch.Elapsed;
                    this.stopwatch.Stop();
                    Console.WriteLine($"\nElapsed time this session {elapsed}");
                    UserDB.UserDatabase userDatabase = new UserDB.UserDatabase();
                    UserDB.User currentUser = userDatabase.GetUser(this.username);
                    if (currentUser != null)
                    {
                        currentUser.WorkingFromHome = currentUser.WorkingFromHome.Add(elapsed);
                        userDatabase.SaveUser(currentUser);
                        Console.WriteLine("Total time spent on Working from home: " + currentUser.WorkingFromHome);
                        currentUser.ElapsedTimeWorking = currentUser.ElapsedTimeWorking.Add(elapsed);
                        userDatabase.SaveUser(currentUser);
                        Console.WriteLine("Total time spent on Working: " + currentUser.ElapsedTimeWorking);
                    }
                    else
                    {
                        Console.WriteLine($"User {this.username} does not exist in the database.");
                    }
                    break;
                }
                Console.CursorLeft = 0;
                Console.Write(this.stopwatch.Elapsed);
            }
        }
    }
}