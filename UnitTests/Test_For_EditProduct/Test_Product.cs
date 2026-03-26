using System;
namespace UnitTests.Test_For_EditProduct
{
    internal class Test_Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Unit { get; set; }
        public string Price { get; set; }
        public Test_Product(int Id, string Name, string Category, string Unit, string Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Category = Category;
            this.Unit = Unit;
            this.Price = Price;
        }
    }
}