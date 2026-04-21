using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CurrencySettings
{
    [Table("currrency_settings")]
    public class CurrencySetting
    {
        ///<summary>
        /// Уникальный идентификатор (GUID)
        /// </summary>
        [Key]
        public Guid id { get; set; }
        ///<summary>
        /// Код валюты (например: USD, EUR)
        /// </summary>
        public string currency_code { get; set; }
        ///<summary>
        /// Последний известный курс к рублю
        /// </summary>
        public decimal exchange_rate { get; set; }
        ///<summary>
        ///Дата и время последнего обновления   
        /// </summary>
        public DateTime updated { get; set; }
    }
}
