using System.ComponentModel.DataAnnotations;

namespace Lending.Functions.Models
{
    public class User_Branch
    {
        [Key]
        public string Id { get; set; }

        public int User_Id { get; set; } = 0;
        public int Branch_Id { get; set; } = 0;

        public int Inactive { get; set; } = 0;
    }
}
