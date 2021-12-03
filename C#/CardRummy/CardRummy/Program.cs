using System;

namespace Encap
{
    class BadItem
    {
        public double unit_price;
        public double adjust_price;
        public double discount;
        public int quantity;
        public string description;
        public string id;

        public BadItem(string id, string description, int quantity, double price)
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

        public double getUnitPrice()
        {
            return unit_price;
        }

        public void setDiscount(double discount)
        {
            if (discount <= 1.00)
            {
                this.discount = discount;
            }
        }

        public double getDiscount()
        {
            return discount;
        }

        public double getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public string getProductID()
        {
            return id;
        }

        public string getDescription()
        {
            return description;
        }

        public double getAdjustedPrice()
        {
            return adjust_price;
        }

        public void setAdjustedPrice(double price)
        {
            adjust_price = price;
        }
        static void Main(string[] args)
        {
            BadItem milk = new BadItem("dairy-01", "1 milk", 2, 2.50);

            milk.setDiscount(.15);
            double milk_price = milk.getQuantity() * milk.getUnitPrice();
            double milk_discount = milk.getDiscount() * milk_price;
            milk.setAdjustedPrice(milk_price - milk_discount);

            Console.WriteLine("Your Milk Price Is : $" + milk.getAdjustedPrice());
        }

    }
}
