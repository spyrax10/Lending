using System;
using System.ComponentModel.DataAnnotations;

namespace Lending.Functions.Models
{
    public class User_Session
    {
        [Key]
        public string Id { get; set; }

        public int User_Id { get; set; } = 0;
        public int Branch_Id { get; set; } = 0;

        public string Date { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public string Time { get; set; } = DateTime.Now.ToString("HH:mm:ss");
        public string IP { get; set; } = null;
        public string PC { get; set; } = null;
        public int Action_Id { get; set; } = 0;

        public string Hash_Id { get; set; } = null;
    }
}
