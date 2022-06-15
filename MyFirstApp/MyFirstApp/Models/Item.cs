using System;

namespace MyFirstApp.Models
{
    public class Item : UniqueItem
    {
        public string Text { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public int Age { get; set; }
    }
}