using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Supplies
{
    [Table("supplies")]
    public class Supplie
    {
        ///<summary>
        /// Уникальный идентификатор категории (GUID)
        /// </summary>
        [Key]
        public Guid id { get; set; }
        ///<summary>
        /// Ссылка на товар
        /// </summary>
        public Guid product_id { get; set; }
        ///<summary>
        /// Количество товара в поставке
        /// </summary>
        public int quantity { get; set; }
        ///<summary>
        /// Цена закупки за единицу
        /// </summary>
        public decimal purchase_price { get; set; }
        ///<summary>
        /// Дата и время поставки
        /// </summary>
        public DateTime supply_date { get; set; }
        ///<summary>
        /// Дата окончания актуальности партии
        /// </summary>
        public int relevance_until { get; set; }
    }
}
