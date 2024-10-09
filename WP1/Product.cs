/*
 * FILE: Product.cs
 * PROJECT: WP_1
 * PROGRAMMER: MANREET THIND (STUDENT ID: 8982315)
 * FIRST VERSION: 09/15/24
 * DESCRIPTION:
 * This file contains the definition of the abstract Product class. 
 * It includes properties common to all products and an abstract method 
 * for calculating discounts. The ToString() method provides a formatted 
 * string representation of the product's details.
 */
using System;

namespace WP_1
{
    /*
     * CLASS: Product
     * Purpose:
     * This abstract class represents a general product with various properties and methods. It serves as a base class for 
     * specific product types like Dairy, Produce, and Cereal.
     */
    public abstract class Product
    {
        /*
         * Property: SKU
         * Purpose: Represents the Stock Keeping Unit of the product.
         * Type: string
         */
        public string SKU { get; set; }

        /*
         * Property: Brand
         * Purpose: Represents the brand of the product.
         * Type: string
         */
        public string Brand { get; set; }

        /*
         * Property: ProductName
         * Purpose: Represents the name of the product.
         * Type: string
         */
        public string ProductName { get; set; }

        /*
         * Property: Size
         * Purpose: Represents the size of the product in grams.
         * Type: int
         */
        public int Size { get; set; }

        /*
         * Property: DateStocked
         * Purpose: Represents the date when the product was stocked.
         * Type: DateTime
         */
        public DateTime DateStocked { get; set; }

        /*
         * Property: ShelfLifeDays
         * Purpose: Represents the number of days the product is expected to be shelf-stable.
         * Type: int
         */
        public int ShelfLifeDays { get; set; }

        /*
         * Property: BaseRetailPrice
         * Purpose: Represents the base retail price of the product.
         * Type: decimal
         */
        public decimal BaseRetailPrice { get; set; }

        /*
         * Property: Discount
         * Purpose: Represents the discount applied to the product.
         * Type: decimal
         */
        public decimal Discount { get; protected set; }

        /*
         * Property: DiscountedPrice
         * Purpose: Calculates and returns the discounted price of the product.
         * Type: decimal
         * Returns: The base retail price minus the discount.
         */
        public decimal DiscountedPrice
        {
            get { return BaseRetailPrice - Discount; }
        }

        // Default constructor
        protected Product() { }

        /*
         * Name    :   Product ---- CONSTRUCTOR
         * Purpose :   Instantiates a Product object with specified values for SKU, Brand, ProductName, Size, DateStocked, 
         *             ShelfLifeDays, and BaseRetailPrice.
         * Input   :   string sku - The SKU of the product.
         *             string brand - The brand of the product.
         *             string productName - The name of the product.
         *             int size - The size of the product in grams.
         *             DateTime dateStocked - The date when the product was stocked.
         *             int shelfLifeDays - The number of days the product is shelf-stable.
         *             decimal baseRetailPrice - The base retail price of the product.
         * Outputs :   NONE
         * Returns :   Nothing
         */
        protected Product(string sku, string brand, string productName, int size, DateTime dateStocked, int shelfLifeDays, decimal baseRetailPrice)
        {
            SKU = sku;
            Brand = brand;
            ProductName = productName;
            Size = size;
            DateStocked = dateStocked;
            ShelfLifeDays = shelfLifeDays;
            BaseRetailPrice = baseRetailPrice;
            CalculateDiscount();
        }

        /*
         * Method: CalculateDiscount
         * Purpose: Abstract method that must be implemented by derived classes to calculate the discount specific to the product.
         * Input: NONE
         * Outputs: NONE
         * Returns: NONE
         */
        protected abstract void CalculateDiscount();

        /*
         * Method: ToString
         * Purpose: Returns a string representation of the product, including details such as SKU, Brand, Product Name, Size, 
         * Date Stocked, Shelf Life, Base Price, Discount, and Discounted Price.
         * Input: NONE
         * Outputs: NONE
         * Returns: string - The string representation of the product.
         */
        public override string ToString()
        {
            return "SKU: " + SKU + "\nBrand: " + Brand + "\nProduct Name: " + ProductName + "\nSize: " + Size + "g" +
                "\nDate Stocked: " + DateStocked.ToString("MMMM d, yyyy") +
                "\nShelf Life: " + ShelfLifeDays + " days" + "\nBase Price: " + BaseRetailPrice.ToString("C") +
                "\nDiscount: " + Discount.ToString("C") + "\nDiscounted Price: " + DiscountedPrice.ToString("C");
        }
    }
}
