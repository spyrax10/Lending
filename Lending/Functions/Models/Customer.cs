using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Lending.Functions.Models
{
    public class Customer
    {
        [Key]
        public string Id { get; set; }

        public string Date { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public int Branch_Id { get; set; } = 0;
        public int Role_Id { get; set; } = 0;

        public string FirstName { get; set; } = null;
        public string MiddleName { get; set; } = null;
        public string LastName { get; set; } = null;
        public decimal Balance { get; set; } = 0;
        public byte[] Photo { get; set; } = null;

        public string Last_Update { get; set; } = "0000-00-00";
        public int Inactive { get; set; } = 0;
        public string Hash_Id { get; set; } = null;
    }
}
