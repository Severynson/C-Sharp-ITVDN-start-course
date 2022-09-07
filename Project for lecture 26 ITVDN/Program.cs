using System;

namespace Project_for_lecture_24_ITVDN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string countryCode;
            decimal tileQuantity, tilePrice;
            {
                const string countryCodes = "\n Азербайджан (994) | Україна (380)" +
                                            "\n Естонiя (372) | Литва (370)";

                Console.WriteLine("Avalible country codes: " + countryCodes);

                Console.WriteLine("Code of country that you need: ");
                countryCode = Console.ReadLine();

                Console.WriteLine("Quantity of the tile: ");
                tileQuantity = Convert.ToUInt32(Console.ReadLine());

                Console.WriteLine("Price for 1m/2 of the tile: ");
                tilePrice = Convert.ToUInt32(Console.ReadLine());
            }

            decimal rate;
            {
                const string AZERBAYJAN_CODE = "994",
                             UKRAINE_CODE = "380",
                             ESTONIA_CODE = "372",
                             LITHUANIA_CODE = "370";

                if (countryCode == AZERBAYJAN_CODE)
                {
                    const decimal AZERBAIJAN_RATE = 1.07m;
                    rate = AZERBAIJAN_RATE;
                }
                else if (countryCode == UKRAINE_CODE)
                {
                    const decimal UKRAINE_RATE = 0;
                    rate = UKRAINE_RATE;
                }
                else if (countryCode == ESTONIA_CODE)
                {
                    const decimal ESTONIA_RATE = .9m;
                    rate = ESTONIA_RATE;
                }
                else if (countryCode == LITHUANIA_CODE)
                {
                    const decimal LITHUANIA_RATE = .8m;
                    rate = LITHUANIA_RATE;
                }
                else
                {
                    // ; // " ; " - Do nothing, but consciously
                    rate = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You just passed not existing code: {countryCode}");
                }
            }

            decimal tilePriceWithRate = tilePrice * rate;
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
                    else if (discount50PstAvalivle)
                    {
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

            {
                Console.WriteLine($"Price with coficient: {tilePriceWithRate}");
                Console.WriteLine($"Cost for all tile:    {tileCost}$");
                Console.WriteLine($"Discount:             {discount}$");
                Console.WriteLine($"Amount for payment:   {paymentAmount}$");
            }


            Console.ReadKey();

        }
    }
}
