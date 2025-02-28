using System;

    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }

        public virtual double GetDiscountedPrice()
        {
            // Base discount rule (no discount)
            return Price;
        }
    }

    public class ElectronicProduct : Product
    {
        public override double GetDiscountedPrice()
        {
            // Apply a 10% discount for electronic products
            return Price * 0.90;
        }
    }

    public class ClothingProduct : Product
    {
        public override double GetDiscountedPrice()
        {
            // Apply a 20% discount for clothing products
            return Price * 0.80;
        }
    }
