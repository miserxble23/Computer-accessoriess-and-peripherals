using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StatusEnum;
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
        /// Единица измерения (шт.)
        /// </summary>
        public string unit { get; set; }

        /// <summary>
        /// Цена продажи товара
        /// </summary>
        private decimal price = 0;

        /// <summary>
        /// Цена товара (не может быть отрицательной)
        /// </summary>
        [Column("price")]
        public decimal Price
        {
            get
            {
                return (this.ValidityStatus == ValidityStatus.Скидка)?price*0.7m:price;
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

        /// <summary>
        /// Цена закупки товара
        /// </summary>
        public decimal purchaseprice { get; set; }
        public DateTime suppliedate { get; set; }

        /// <summary>
        /// Срок актуальности товара в месяцах (задаётся при поставке)
        /// </summary>
        public int? ValidityMonths { get; set; }
        public ValidityStatus ValidityStatus
        {
            get => CalculateValidityStatus();
        }

        /// <summary>
        /// Процент скидки (рассчитывается автоматически)
        /// </summary>

        // Метод расчёта статуса
        private ValidityStatus CalculateValidityStatus()
        {
            if (!ValidityMonths.HasValue || suppliedate == new DateTime(2000, 01, 01))
                return ValidityStatus.Отсутствует;

            var elapsedDays = (decimal)(DateTime.Now - suppliedate).TotalDays;
            var daysPerMonth = 30.44m;
            var elapsedMonths = elapsedDays / daysPerMonth;

            var totalMonths = (decimal)ValidityMonths.Value;
            var threshold = totalMonths * 2 / 3; // 2/3 срока

            if (elapsedMonths >= totalMonths)
                return ValidityStatus.Устарело;
            else if (elapsedMonths >= threshold)
                return ValidityStatus.Скидка;
            else
                return ValidityStatus.Актуально;
        }
    }
}
