﻿namespace BurgerApp.Domain.Models
{
    public class Burger:BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }



    }
}
