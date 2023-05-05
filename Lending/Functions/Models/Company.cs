using System;
using System.ComponentModel.DataAnnotations;

namespace Lending.Functions.Models
{
    public class Company
    {
        [Key]
        public string Id { get; set; }

        public string Date { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public int Parent_Id { get; set; } = 0;
        public int Owner_Id { get; set; } = 0;
        public string Code { get; set; } = null;
        public string Name { get; set; } = null;
        public string TIN { get; set; } = null;
        public int Enable_logs { get; set; } = 0;
        public int Display_per_page { get; set; } = 0;

        public string Last_Update { get; set; } = "0000-00-00";
        public int Inactive { get; set; } = 0;
        public string Hash_Id { get; set; } = null;
    }
}
