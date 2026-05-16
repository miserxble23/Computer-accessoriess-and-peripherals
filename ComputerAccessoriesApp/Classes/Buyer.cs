using System;
using System.Collections.Generic;
using System.Text;
namespace ComputerAccessoriesApp.Classes
{
    public class Buyer
    {
        public Guid Id { get; set; }
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string Passport { get; set; }
        public string INN { get; set; }
        public string SNILS { get; set; }
    }
}
