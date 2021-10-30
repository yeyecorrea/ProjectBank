namespace ProjectBank
{
    public class User
    {
        private string name { get; set; }
        private string lastName { get; set; }
        private int privateKey { get; set; }
        public User(string name, string lastName, int privateKey)
        {
            this.name = name;
            this.lastName = lastName;
            this.privateKey = privateKey; 
        }

        public void CreateUser()
        {

        }
    }
}