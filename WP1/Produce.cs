/*
 * FILE: Produce.cs
 * PROJECT: WP_1
 * PROGRAMMER: MANREET THIND (STUDENT ID: 8982315)
 * FIRST VERSION: 09/15/24
 * DESCRIPTION:
 * This file contains the definition of the Produce class, which inherits 
 * from the Product class. It includes properties specific to produce items 
 * and overrides the CalculateDiscount() method to provide a discount based 
 * on expiration. The ToString() method is overridden to include information 
 * about how the product is sold and its category.
 */
using System;

namespace WP_1
{
    /*
     * CLASS: Produce
     * Purpose:
     * This class represents a Produce product and inherits from the Product class. It includes additional properties for 
     * the selling method and product category and implements the CalculateDiscount method specific to Produce products.
     */
    public class Produce : Product
    {
        /*
         * Property: SoldBy
         * Purpose: Represents the method by which the produce is sold (e.g., weight).
         * Type: string
         */
        public string SoldBy { get; set; }

        /*
         * Property: ProductCategory
         * Purpose: Represents the category of the produce (e.g., fruit, vegetable).
         * Type: string
         */
        public string ProductCategory { get; set; }

        // Default constructor
        public Produce() { }

        /*
         * Name    :   Produce ---- CONSTRUCTOR
         * Purpose :   Instantiates a Produce object with specified values for SKU, Brand, ProductName, Size, DateStocked, 
         *             ShelfLifeDays, BaseRetailPrice, SoldBy, and ProductCategory.
         * Input   :   string sku - The SKU of the product.
         *             string brand - The brand of the product.
         *             string productName - The name of the product.
         *             int size - The size of the product in grams.
         *             DateTime dateStocked - The date when the product was stocked.
         *             int shelfLifeDays - The number of days the product is shelf-stable.
         *             decimal baseRetailPrice - The base retail price of the product.
         *             string soldBy - The method by which the produce is sold.
         *             string productCategory - The category of the produce.
         * Outputs :   NONE
         * Returns :   Nothing
         */
        public Produce(string sku, string brand, string productName, int size, DateTime dateStocked, int shelfLifeDays, decimal baseRetailPrice, string soldBy, string productCategory)
            : base(sku, brand, productName, size, dateStocked, shelfLifeDays, baseRetailPrice)
        {
            SoldBy = soldBy;
            ProductCategory = productCategory;
        }

        /*
         * Method: CalculateDiscount
         * Purpose: Calculates the discount specific to Produce products. If the product is close to its expiration date (5 days 
         * or less), a 50% discount is applied. If it has 6-10 days to expiration, a 20% discount is applied. Otherwise, no 
         * discount is applied.
         * Input: NONE
         * Outputs: NONE
         * Returns: NONE
         */
        protected override void CalculateDiscount()
        {
            var daysToExpiration = (DateStocked.AddDays(ShelfLifeDays) - DateTime.Now).Days;
            if (daysToExpiration <= 5)
            {
                Discount = BaseRetailPrice * 0.50m;
            }
            else if (daysToExpiration <= 10)
            {
                Discount = BaseRetailPrice * 0.20m;
            }
            else
            {
                Discount = 0m; // No discount otherwise
            }
        }

        /*
         * Method: ToString
         * Purpose: Returns a string representation of the Produce product, including additional SoldBy and ProductCategory information.
         * Input: NONE
         * Outputs: NONE
         * Returns: string - The string representation of the Produce product.
         */
        public override string ToString()
        {
            return base.ToString() + "\nSold By: " + SoldBy + "\nCategory: " + ProductCategory;
        }
    }
}
