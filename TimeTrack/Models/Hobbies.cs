namespace TimeTrack.Models
{
    public class Hobbies
    {
        private List<string> hobbiesList;

        public Hobbies()
        {
            hobbiesList = new List<string>();
        }
        public void AddHobby(string hobby)
        {
            hobbiesList.Add(hobby);
        }
        public int Count
        {
        get { return hobbiesList.Count; }
        }
        public List<string> GetHobbies()
        {
            return hobbiesList;
        }
    }
}
