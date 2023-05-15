using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System;
using TimeTrack.Models;
using static TimeTrack.DataBases.UserDB;

namespace TimeTrack.DataBases
{
    public class UserDB
    {
        public class User
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public TimeSpan ElapsedTimeReading { get; set; }
            public TimeSpan ElapsedTimeExercising { get; set; }
            public TimeSpan ElapsedTimeWorking { get; set; }


            //SubActivities Reading
            public TimeSpan BellesLettres { get; set; }
            public TimeSpan Fiction { get ; set; }
            public TimeSpan ProfessionalLiterature { get; set; }  

            //SubActivities Excercising 
            public TimeSpan GeneralExercise { get; set; }
            public TimeSpan Running { get; set; }
            public TimeSpan Sport { get; set; }

            //SubActivities Working
            public TimeSpan WorkingFromOffice { get; set; }
            public TimeSpan WorkingFromHome { get; set;}


        }

        public class UserDatabase
        {
            private const string UserDatabaseFilePath = "C:\\Users\\Zdevan\\OneDrive\\Desktop\\TimeTrack\\users.json";
            private List<User> users;

            public UserDatabase()
            {
                if (File.Exists(UserDatabaseFilePath))
                {
                    string json = File.ReadAllText(UserDatabaseFilePath);
                    users = JsonConvert.DeserializeObject<List<User>>(json);
                }
                else
                {
                    users = new List<User>();
                }
            }

            public void AddUser(User user)
            {
                users.Add(user);
                SaveToFile();
            }

            public bool UserExists(string username)
            {
                return users.Exists(u => u.Username == username);
            }

            public void SaveToFile()
            {
                string json = JsonConvert.SerializeObject(users);
                File.WriteAllText(UserDatabaseFilePath, json);
            }
            public void SaveUser(User user)
            {
                int index = users.FindIndex(u => u.Username == user.Username);
                if (index >= 0)
                {
                    users[index] = user;
                }
                else
                {
                    throw new ArgumentException("User does not exist in database");
                }
                SaveToFile();
            }
            public User GetUser(string username)
            {
                User user = users.Find(u => u.Username == username);
                if (user == null)
                {
                    throw new ArgumentException("User does not exist in database");
                }
                return user;
            }
        }
    }
}
