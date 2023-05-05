using System;
using System.ComponentModel.DataAnnotations;

namespace Lending.Functions.Models
{
    public class Addresses
    {
        [Key]
        public string Id { get; set; }

        public string Date { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public int User_Id { get; set; } = 0;
        public int Branch_Id { get; set; } = 0;
        public int Type { get; set; } = 0;

        public string Country { get; set; } = null;
        public string Province { get; set; } = null;
        public string Municipality { get; set; } = null;
        public string Barangay { get; set; } = null;
        public string Street { get; set; } = null;
        public string ZipCode { get; set; } = null;

        public string Last_Update { get; set; } = "0000-00-00";
        public int Inactive { get; set; } = 0;
        public string Hash_Id { get; set; } = null;
    }
}
