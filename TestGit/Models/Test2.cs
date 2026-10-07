using System.ComponentModel.DataAnnotations;
namespace TestGit.Models
{
    public class Test2
    {
        public int Id { get; set; }
        public string? Address { get; set; } = string.Empty;
        [DataType(DataType.Password)]
        public required string Password { get; set; }
        public required string FullName { get; set; }
    }
}
