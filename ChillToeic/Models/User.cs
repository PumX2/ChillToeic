namespace ChillToeic.Models
{
    using System;

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
