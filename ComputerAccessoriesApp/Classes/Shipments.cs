using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Shipments
{
    /// <summary>
    /// Отгрузка товара
    /// </summary>
    [Table("sshipments")]
    public class Shipment
    {
        ///<summary>
        /// Уникальный идентификатор (GUID)
        /// </summary>
        [Key]
        public Guid id { get; set; }
        ///<summary>
        /// Ссылка на товар
        /// </summary>
        public Guid product_id { get; set; }
        ///<summary>
        /// Имя или название покупателя
        /// </summary>
        public string customer {  get; set; }
        ///<summary>
        /// Количество отгруженного товара
        /// </summary>
        public int quantity { get; set; }
        ///<summary>
        /// Цена продажи на момент отгрузки
        /// </summary>
        public decimal sale_ptice { get; set; }
        ///<summary>
        /// Дата отгрузки
        /// </summary>
        public DateTime shipment_date { get; set; }
        ///<summary>
        /// Сумма отгрузки (quantity × sale_price)
        /// </summary>
        public decimal total_sum { get; set; }
    }
}
