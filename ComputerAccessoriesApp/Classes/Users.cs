using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Users
{
    /// <summary>
    /// Пользователь системы (администратор или кладовщик)
    /// </summary>
    [Table("users")]
    public class User
    {
        /// <summary>
        /// Уникальный идентификатор пользователя (GUID)
        /// </summary>
        [Key]
        public Guid id { get; set; }

        /// <summary>
        /// Имя пользователя (логин)
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Дополнительный код (например, для регистрации)
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// Роль пользователя (admin или storekeeper)
        /// </summary>
        public string role { get; set; }
    }
}
