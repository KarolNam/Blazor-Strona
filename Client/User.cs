namespace BlazorApp
{
    public class User
    {
        public User()
        {
            
        }
        public User(int id, string fn, string ln)
        {
            UserId = id;
            FirstName = fn;
            LastName = ln;
        }
        public int UserId {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}