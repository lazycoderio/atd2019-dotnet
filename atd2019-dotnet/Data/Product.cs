using System;

namespace workshop.Data
{
    public class Product
    {
        private static String name;

        public static Product Valid()
        {
            name = "Sauce Labs Backpack";
            return new Product();
        }

        public String GetName()
        {
            return name;
        }
        
    }
}