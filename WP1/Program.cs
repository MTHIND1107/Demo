/*
 * FILE: Program.cs
 * PROJECT: WP_1
 * PROGRAMMER: MANREET THIND (STUDENT ID: 8982315)
 * FIRST VERSION: 09/15/24
 * DESCRIPTION:
 * This file contains the entry point for the application. It demonstrates 
 * the usage of the Dairy, Produce, and Cereal classes by creating instances 
 * of each, displaying their information, and waiting for user input before 
 * exiting.
 */
using System;

namespace WP_1
{
    /*
     * CLASS: Program
     * Purpose:
     * The main entry point of the application. It demonstrates the creation and usage of Dairy, Produce, and Cereal products 
     * by displaying their information.
     */
    internal class Program
    {
        /*
         * Name    :   Main ---- METHOD
         * Purpose :   The main method where the application starts. It creates instances of Dairy, Produce, and Cereal products, 
         *             displays their information, and waits for user input before exiting.
         * Input   :   string[] args - Command-line arguments (not used in this program).
         * Outputs :   Displays information about the Dairy, Produce, and Cereal products.
         * Returns :   int - Returns 0 upon successful completion.
         */
        static void Main(string[] args)
        {
            // Set the current date for testing purposes
            DateTime currentDate = new DateTime(2024, 9, 11);

            // Create instances of each subclass with the exact dates and details needed
            Dairy dairyProduct = new Dairy("D123", "DairyBrand", "Milk", 500, new DateTime(2024, 9, 8), 7, 3.99m, true);
            Produce produceProduct = new Produce("P456", "ProduceBrand", "Apple", 200, new DateTime(2024, 9, 16), 7, 1.99m, "Weight", "Fruit");
            Cereal cerealProduct = new Cereal("C789", "CerealBrand", "Cornflakes", 300, new DateTime(2024, 8, 31), 30, 4.99m, 20);

            // Demonstrate inherited properties and ToString() method
            Console.WriteLine("Dairy Product Info:");
            Console.WriteLine(dairyProduct.ToString());
            Console.WriteLine();

            Console.WriteLine("Produce Product Info:");
            Console.WriteLine(produceProduct.ToString());
            Console.WriteLine();

            Console.WriteLine("Cereal Product Info:");
            Console.WriteLine(cerealProduct.ToString());

            // Wait for user input before exiting
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
