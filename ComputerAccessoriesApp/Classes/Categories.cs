using System.ComponentModel.DataAnnotations.Schema;
namespace Products
{
    [Table("categories")]
    public class Category
    {
        public int id { get; set; }

        public string name { get; set; }
    }
}
