/*
 * FILE: Dairy.cs
 * PROJECT: WP_1
 * PROGRAMMER: MANREET THIND (STUDENT ID: 8982315)
 * FIRST VERSION: 09/15/24
 * DESCRIPTION:
 * This file contains the definition of the Dairy class, which inherits 
 * from the Product class. It includes a property specific to dairy products 
 * and overrides the CalculateDiscount() method to provide a discount based 
 * on expiration. The ToString() method is overridden to include information 
 * about whether the product is lactose-free.
 */
using System;

namespace WP_1
{
    /*
     * CLASS: Dairy
     * Purpose:
     * This class represents a Dairy product and inherits from the Product class. It includes an additional property for 
     * indicating if the product is lactose-free and implements the CalculateDiscount method specific to Dairy products.
     */
    public class Dairy : Product
    {
        /*
         * Property: LactoseFree
         * Purpose: Indicates whether the Dairy product is lactose-free.
         * Type: bool
         */
        public bool LactoseFree { get; set; }

        // Default constructor
        public Dairy() { }

        /*
         * Name    :   Dairy ---- CONSTRUCTOR
         * Purpose :   Instantiates a Dairy object with specified values for SKU, Brand, ProductName, Size, DateStocked, 
         *             ShelfLifeDays, BaseRetailPrice, and LactoseFree.
         * Input   :   string sku - The SKU of the product.
         *             string brand - The brand of the product.
         *             string productName - The name of the product.
         *             int size - The size of the product in grams.
         *             DateTime dateStocked - The date when the product was stocked.
         *             int shelfLifeDays - The number of days the product is shelf-stable.
         *             decimal baseRetailPrice - The base retail price of the product.
         *             bool lactoseFree - Indicates if the product is lactose-free.
         * Outputs :   NONE
         * Returns :   Nothing
         */
        public Dairy(string sku, string brand, string productName, int size, DateTime dateStocked, int shelfLifeDays, decimal baseRetailPrice, bool lactoseFree)
            : base(sku, brand, productName, size, dateStocked, shelfLifeDays, baseRetailPrice)
        {
            LactoseFree = lactoseFree;
        }

        /*
         * Method: CalculateDiscount
         * Purpose: Calculates the discount specific to Dairy products. If the product is close to its expiration date (5 days or 
         * less), a 50% discount is applied. Otherwise, no discount is applied.
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
            else
            {
                Discount = 0m; // No discount otherwise
            }
        }

        /*
         * Method: ToString
         * Purpose: Returns a string representation of the Dairy product, including additional LactoseFree information.
         * Input: NONE
         * Outputs: NONE
         * Returns: string - The string representation of the Dairy product.
         */
        public override string ToString()
        {
            return base.ToString() + "\nLactose Free: " + (LactoseFree ? "Yes" : "No");
        }
    }
}
