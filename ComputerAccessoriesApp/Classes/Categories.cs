using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Categories
{
    /// <summary>
    /// Категория товара (например: клавиатуры, мыши и т.д.)
    /// </summary>
    [Table("categories")]
    public class Category
    {
        ///<summary>
        /// Уникальный идентификатор категории (GUID)
        /// </summary>
        [Key]
        public Guid id { get; set; }

        /// <summary>
        /// Название категории
        /// </summary>
        public string name { get; set; }
    }
}
