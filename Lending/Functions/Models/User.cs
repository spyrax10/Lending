using System.ComponentModel.DataAnnotations;
using System;

namespace Lending.Functions.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }

        public string Date { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public int Branch_Id { get; set; } = 0;
        public int Role_Id { get; set; } = 0;

        public string Username { get; set; } = null;
        public string Password { get; set; } = null;

        public string FirstName { get; set; } = null;
        public string MiddleName { get; set; } = null;
        public string LastName { get; set; } = null;
        public string Date_Hired { get; set; } = "0000-00-00";
        public byte[] Photo { get; set; } = null;

        public string Last_Update { get; set; } = "0000-00-00";
        public int Inactive { get; set; } = 0;
        public string Hash_Id { get; set; } = null;
    }
}
