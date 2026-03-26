using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Products
{
    /// <summary>
    /// Товар в системе (например: мышь, клавиатура и т.д.)
    /// </summary>
    [Table("products")]
    public class Product
    {
        /// <summary>
        /// Уникальный идентификатор товара (GUID)
        /// </summary>
        [Key]
        public Guid id { get; set; }

        /// <summary>
        /// Название товара
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Категория товара
        /// </summary>
        public string category { get; set; }

        /// <summary>
        /// Количество товара на складе
        /// </summary>
        public int stock { get; set; }

        /// <summary>
        /// Единица измерения (шт, кг и т.д.)
        /// </summary>
        public string unit { get; set; }

        private decimal price;

        /// <summary>
        /// Цена товара (не может быть отрицательной)
        /// </summary>
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
    }
}
