using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Shipments
{
    /// <summary>
    /// Отгрузка товара
    /// </summary>
    [Table("shipments")]
    public class Shipment
    {
        ///<summary>
        /// Уникальный идентификатор (GUID)
        /// </summary>
        [Key]
        public Guid id { get; set; }
        ///<summary>
        /// Дата отгрузки товара
        /// </summary>
        public DateTime shipment_date { get; set; }
        ///<summary>
        /// Ссылка на товар
        /// </summary>
        public Guid product_id { get; set; }
        ///<summary>
        /// Количество отгруженного товара
        /// </summary>
        public int quantity { get; set; }
        ///<summary>
        /// Цена продажи на момент отгрузки
        /// </summary>
        public decimal saleprice { get; set; }
        ///<summary>
        /// Дата отгрузки
        /// </summary>
        public decimal purchaseprice { get; set; }
        ///<summary>
        /// Сумма прибыли
        /// </summary>
        public decimal impactsum 
        {
            get
            {
                return (saleprice - purchaseprice) * quantity;
            }
            set { }
        }
    }
}
