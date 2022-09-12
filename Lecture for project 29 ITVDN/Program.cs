using System;

namespace Lecture_for_project_29_ITVDN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int counter = 0;

            while (counter < 3)
            {
                Console.WriteLine($"BLOCK: counter = {counter}");
                counter++;
            }

            Console.WriteLine($"MAIN: counter = {counter}");
            */

            while (true)
            {
                string countryCode;
                decimal tileQuantity, tilePrice;

                {
                    const string countryCodes = "\n Азербайджан (994) | Україна (380)" +
                                                "\n Естонiя (372) | Литва (370) | Казахстан (007K)";

                    Console.WriteLine(
                        "\n\t*********************" +
                        "\n\t*********************" +
                        "\n\t*********************" +
                        "\n\nAvalible country codes: " + countryCodes);

                    Console.WriteLine("Code of country that you need: ");
                    countryCode = Console.ReadLine();

                    {
                        const string KAZAHSTAN_CODE = "007";
                        const string UPPERCASE_ENG_LETTER_K = "K", LOWERCASE_ENG_LETTER_K = "k",
                                     UPPERCASE_KIRILIAN_LETTER_K = "К", LOWERCASE_KIRILIAN_LETTER_K = "к";



                        bool COUNTRY_CODE_IS_KAZAHSTAN_CODE_AND_ANY_LETTER_K =
                            countryCode == (KAZAHSTAN_CODE + UPPERCASE_ENG_LETTER_K) ||
                            countryCode == (KAZAHSTAN_CODE + LOWERCASE_ENG_LETTER_K) ||
                            countryCode == (KAZAHSTAN_CODE + UPPERCASE_KIRILIAN_LETTER_K) ||
                            countryCode == (KAZAHSTAN_CODE + LOWERCASE_KIRILIAN_LETTER_K);
                    }

                    Console.WriteLine("Quantity of the tile: ");
                    tileQuantity = Convert.ToUInt32(Console.ReadLine());

                    Console.WriteLine("Price for 1m/2 of the tile: ");
                    tilePrice = Convert.ToUInt32(Console.ReadLine());
                }

                decimal rate;
                {
                    const string UPPERCASE_ENGLISH_LETTER_K = "K";
                    const string AZERBAYJAN_CODE = "994",
                                 UKRAINE_CODE = "380",
                                 ESTONIA_CODE = "372",
                                 LITHUANIA_CODE = "370",
                                 KAZAHSTAN_CODE = "007" + UPPERCASE_ENGLISH_LETTER_K;

                    switch (countryCode)
                    {
                        case AZERBAYJAN_CODE:
                            {
                                const decimal AZERBAIJAN_RATE = 1.07m;
                                rate = AZERBAIJAN_RATE;
                                break;
                            }
                        case UKRAINE_CODE:
                            {
                                const decimal UKRAINE_RATE = .6m;
                                rate = UKRAINE_RATE;
                                break;
                            }
                        case ESTONIA_CODE:
                            {
                                const decimal ESTONIA_RATE = .9m;
                                rate = ESTONIA_RATE;
                                break;
                            }
                        case LITHUANIA_CODE:
                            {
                                const decimal LITHUANIA_RATE = .8m;
                                rate = LITHUANIA_RATE;
                                break;
                            }
                        case KAZAHSTAN_CODE:
                            {
                                const decimal KAZAHSTAN_RATE = 1.2m;
                                rate = KAZAHSTAN_RATE;
                                break;
                            }
                        default:
                            {
                                // ; // " ; " - Do nothing, but consciously
                                rate = 0;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"You just passed not existing code: {countryCode}");
                                Console.ForegroundColor = ConsoleColor.White; 
                                break;
                            };

                            /*
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
                            */
                    }

                }

                decimal tilePriceWithRate = tilePrice * rate;
                decimal tileCost = tileQuantity * tilePriceWithRate;

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
                    Console.WriteLine($"Price for m/2 with coficient: {tilePriceWithRate}$");
                    Console.WriteLine($"Cost for all tile:    {tileCost}$");
                    Console.WriteLine($"Discount:             {discount}$");
                    Console.WriteLine($"Amount for payment:   {paymentAmount}$");
                }


                Console.ReadKey();
            };
        }
    }
}
