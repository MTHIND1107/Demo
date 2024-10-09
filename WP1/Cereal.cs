/*
 * FILE: Cereal.cs
 * PROJECT: WP_1
 * PROGRAMMER: MANREET THIND (STUDENT ID: 8982315)
 * FIRST VERSION: 09/15/24
 * DESCRIPTION:
 * This file contains the definition of the Cereal class, which inherits 
 * from the Product class. It includes a property specific to cereal products 
 * and overrides the CalculateDiscount() method to provide a discount based 
 * on expiration. The ToString() method is overridden to include information 
 * about the sugar content of the cereal.
 */
using System;

namespace WP_1
{
    /*
     * CLASS: Cereal
     * Purpose:
     * This class represents a Cereal product and inherits from the Product class. It includes an additional property for sugar 
     * content and implements the CalculateDiscount method specific to Cereal products.
     */
    public class Cereal : Product
    {
        /*
         * Property: Sugar
         * Purpose: Represents the sugar content of the Cereal product as a percentage.
         * Type: int
         */
        public int Sugar { get; set; }

        // Default constructor
        public Cereal() { }

        /*
         * Name    :   Cereal ---- CONSTRUCTOR
         * Purpose :   Instantiates a Cereal object with specified values for SKU, Brand, ProductName, Size, DateStocked, 
         *             ShelfLifeDays, BaseRetailPrice, and Sugar.
         * Input   :   string sku - The SKU of the product.
         *             string brand - The brand of the product.
         *             string productName - The name of the product.
         *             int size - The size of the product in grams.
         *             DateTime dateStocked - The date when the product was stocked.
         *             int shelfLifeDays - The number of days the product is shelf-stable.
         *             decimal baseRetailPrice - The base retail price of the product.
         *             int sugar - The sugar content of the product as a percentage.
         * Outputs :   NONE
         * Returns :   Nothing
         */
        public Cereal(string sku, string brand, string productName, int size, DateTime dateStocked, int shelfLifeDays, decimal baseRetailPrice, int sugar)
            : base(sku, brand, productName, size, dateStocked, shelfLifeDays, baseRetailPrice)
        {
            Sugar = sugar;
        }

        /*
         * Method: CalculateDiscount
         * Purpose: Calculates the discount specific to Cereal products. If the product is expired (i.e., past its shelf life), 
         * a 50% discount is applied. Otherwise, no discount is applied.
         * Input: NONE
         * Outputs: NONE
         * Returns: NONE
         */
        protected override void CalculateDiscount()
        {
            if (DateStocked.AddDays(ShelfLifeDays) < DateTime.Now)
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
         * Purpose: Returns a string representation of the Cereal product, including additional Sugar information.
         * Input: NONE
         * Outputs: NONE
         * Returns: string - The string representation of the Cereal product.
         */
        public override string ToString()
        {
            return base.ToString() + "\nSugar: " + Sugar + "%";
        }
    }
}
