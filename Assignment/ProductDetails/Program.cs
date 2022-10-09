using System;
using System.Collections.Generic;

namespace ProductDetails
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FreshGrocery freshGrocery = new FreshGrocery();
            freshGrocery.Name = "Fresh grocery";
            freshGrocery.Price = 30;
            freshGrocery.Weight = 1;

            Grocery grocery = new Grocery();
            grocery.Name = "Grocery";
            grocery.Price = 50;
            grocery.Quantity = 2;

            ShoppingCart cart = new ShoppingCart();
            cart.Orders = new List<GroceryItem>();
            cart.Orders.Add(freshGrocery);
            cart.Orders.Add(grocery);

            double price = cart.Calculate();
            Console.WriteLine("Price: {0}", price);
            Console.ReadLine();
        }
    }

    abstract class GroceryItem
    {
        private string name;
        private double price = 0;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public abstract double Calculate();
    }

    class FreshGrocery : GroceryItem
    {
        private double weight = 0;

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public override double Calculate()
        {
            return this.Price * this.Weight;
        }
    }

    class Grocery : GroceryItem
    {
        private int quantity = 0;
        private double gst = 10; // In Percentage

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public override double Calculate()
        {
            double calculatedPrice = this.Price * this.Quantity;

            // VAT
            if (calculatedPrice > 0)
            {
                calculatedPrice += calculatedPrice * (gst / 100);
            }

            return calculatedPrice;
        }
    }

    class ShoppingCart
    {
        private List<GroceryItem> orders;

        public List<GroceryItem> Orders
        {
            get
            {
                return orders;
            }
            set
            {
                orders = value;
            }
        }

        public double Calculate()
        {
            double price = 0;
            if (this.Orders != null)
            {

                foreach (GroceryItem order in this.Orders)
                {
                    price += order.Calculate();
                }

            }
            return price;

        }
    }
}

