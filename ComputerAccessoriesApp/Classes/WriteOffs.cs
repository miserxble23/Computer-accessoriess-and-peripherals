using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WriteOffs
{
    [Table("write_offs")]
    public class WriteOff
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
        /// Списанное количество
        /// </summary>
        public int quantity { get; set; }
        ///<summary>
        /// Цена закупки (для расчёта убытка)
        /// </summary>
        public decimal purchase_price { get; set; }
        ///<summary>
        /// Убыток (quantity × purchase_price)
        /// </summary>
        public decimal loss_amount { get; set; }
        ///<summary>
        /// Дата списания
        /// </summary>
        public DateTime write_off_date { get; set; }
        ///<summary>
        /// Причина (например: «Истёк срок годности»)
        /// </summary>
        public string reason { get; set; }
    }
}
