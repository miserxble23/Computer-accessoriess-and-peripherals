using System.ComponentModel.DataAnnotations.Schema;
namespace Users
{
    [Table("users")]
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string code { get; set; }
        public string role { get; set; }
    }
}
