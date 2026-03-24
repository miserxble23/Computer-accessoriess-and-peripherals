using System.ComponentModel.DataAnnotations.Schema;
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
        private decimal price;
        [Column("price")]
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Цена не может быть отрицательной!");
                }
                else
                {
                    price = value;
                }
            }
        }
<<<<<<< HEAD
        
=======
>>>>>>> 952dc77 (Добавлена инкапсуляция для поля price в классе Products)
    }
}
