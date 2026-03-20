using System.ComponentModel.DataAnnotations.Schema;
namespace Products
{
    [Table("products")]
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public int stock { get; set; }
        public string unit { get; set; }
        public decimal price { get; set; }
    }
}