using System;

namespace Project_for_lecture_24_ITVDN
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal tileQuantity, tilePrice;
            {
                Console.WriteLine("Quantity of the tile: ");
                tileQuantity = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Price for 1m/2 of the tile: ");
                tilePrice = Convert.ToUInt32(Console.ReadLine());
            }

            decimal tileCost = tileQuantity * tilePrice;

            decimal discount;
            {
                bool discount20PstAvalivle, discount50PstAvalivle;
                {
                    const decimal MIN_TILE_QUANTITY_FOR_DISCOUNT_50_PCT = 1000,
                                  MIN_TILE_QUANTITY_FOR_DISCOUNT_20_PCT = 500;
                    discount20PstAvalivle = tileQuantity >= MIN_TILE_QUANTITY_FOR_DISCOUNT_20_PCT &&
                                            tileQuantity < MIN_TILE_QUANTITY_FOR_DISCOUNT_50_PCT;

                    discount50PstAvalivle = tileQuantity >= MIN_TILE_QUANTITY_FOR_DISCOUNT_50_PCT;
                }


                decimal discountPercentage;
                {
                    if (discount20PstAvalivle)
                    {
                        discountPercentage = 20; // %
                    }
                    else if (discount50PstAvalivle) {
                        discountPercentage = 50; // %
                    }
                    else
                    {
                        discountPercentage = 10; // %
                    }
                    discount = (tileCost / 100) * discountPercentage;
                }
            }

            decimal paymentAmount = tileCost - discount;

            Console.WriteLine($"Cost for all tile:   {tileCost}$");
            Console.WriteLine($"Discount:            {discount}$");
            Console.WriteLine($"Amount for payment:  {paymentAmount}$");

            Console.ReadKey();

        }
    }
}
