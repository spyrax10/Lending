using System;
using System.ComponentModel.DataAnnotations;

namespace Lending.Functions.Models
{
    public class Contacts
    {
        [Key]
        public string Id { get; set; }

        public string Date { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public int User_Id { get; set; } = 0;
        public int Branch_Id { get; set; } = 0;
        public int Type { get; set; } = 0;

        public string Email { get; set; } = null;
        public string FB { get; set; } = null;
        public string Mobile { get; set; } = null;
        public string Telephone { get; set; } = null;
        public int Secondary { get; set; } = 0;
        public int Email_Verified { get; set; } = 0;
        public int Mobile_Verified { get; set; } = 0;
        public int Authen_ON { get; set; } = 0; 

        public string Last_Update { get; set; } = "0000-00-00";
        public int Inactive { get; set; } = 0;
        public string Hash_Id { get; set; } = null;
    }
}
