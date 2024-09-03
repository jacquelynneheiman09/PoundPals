namespace Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public float StartingWeight { get; set; }
        public float CurrentWeight { get; set; }
        public float TargetWeight { get; set; }
        public DateTime JoinDate { get; set; }

        public User() {
            Id = new Guid();
            Username = "";
            Email = "";
            PasswordHash = "";
        }
    }
}