using System;

namespace SampleOops
{    
    public class Item
    {
        private double unit_price;
        private double discount; 
        private int quantity;
        private string description;
        private string id;

        public Item(string id, string description, int quantity, double price)
        {
            this.id = id;
            this.description = description;
            if (quantity >= 0)
            {
                this.quantity = quantity;
            }
            else
            {
                this.quantity = 0;
            }
            this.unit_price = price;
        }
        public double GetAdjustedTotal()
        {
            double total = unit_price * quantity;
            double total_discount = total * discount;
            double adjusted_total = total - total_discount;
            return adjusted_total;
        }
        public void SetDiscount(double discount)
        {
            if (discount <= 1.00)
            {
                this.discount = discount;
            }
            else
            {
                this.discount = 0.0;
            }
        }
        public double GetDiscount()
        {
            return discount;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public void SetQuantity(int quantity)
        {
            if (quantity >= 0)
            {
                this.quantity = quantity;
            }
        }
        public string GetProductID()
        {
            return id;
        }
        public string GetDescription()
        {
            return description;
        }
        public static void Main(string[] args)
        {
            Item milk = new Item("dairy - 011", "1 Gallon Milk", 2, 2.50);
            Item yogurt = new Item("dairy - 032", "Peach Yogurt", 4, 0.68);
            Item bread = new Item("bakery - 023", "Sliced Bread", 1, 2.55);
            Item soap = new Item("household - 21", "6 Pack Soap", 1, 4.51);

            milk.SetDiscount(0.15);
            soap.SetDiscount(0.75);
            bread.SetDiscount(0.90);

            double milk_price = milk.GetAdjustedTotal();
            double yogurt_price = yogurt.GetAdjustedTotal();
            double bread_price = bread.GetAdjustedTotal();
            double soap_price = soap.GetAdjustedTotal();

            Console.WriteLine("\n Thank For Your Purchase..!");
            Console.WriteLine("Come Again Please..! \n");
            Console.WriteLine(milk.GetDescription() + "\t" + milk_price);
            Console.WriteLine(yogurt.GetDescription() + "\t" +yogurt_price);
            Console.WriteLine(bread.GetDescription() + "\t" +bread_price);
            Console.WriteLine(soap.GetDescription() + "\t" +soap_price);
            Console.WriteLine("\n");

            double total = milk_price + yogurt_price + bread_price + soap_price;
            Console.WriteLine("Total Price :\t" + total + "\n");
        }
    }
}
