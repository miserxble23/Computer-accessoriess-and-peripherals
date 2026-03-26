using System;
namespace UnitTests
{
    internal class Test_For_CardStorekep_Method
    {
        public string id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string stock { get; set; }
        public string unit { get; set; }
        public string price { get; set; }
        public Test_For_CardStorekep_Method(string id, string name, string category, string stock, string unit, string price)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Неверные данные");
            }
            this.id = id;
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Неверные данные");
            }
            this.name = name;
            if (string.IsNullOrEmpty(category))
            {
                throw new ArgumentException("Неверные данные");
            }
            this.category = category;
            if (string.IsNullOrEmpty(stock))
            {
                throw new ArgumentException("Неверные данные");
            }
            this.stock = stock;
            if (string.IsNullOrEmpty(unit))
            {
                throw new ArgumentException("Неверные данные");
            }
            this.unit = unit;
            if (string.IsNullOrEmpty(price))
            {
                throw new ArgumentException("Неверные данные");
            }
            this.price = price;
        }

    }
}