using System;

namespace Project_for_lecture_21_ITVDN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int roomTotalCost = default(int);

            // Upper and lower examples are not the same if talking not about class's scope

            int roomTotalCost;

            {
                int roomLength = 5, roomWidth = 4, roomArea = roomLength * roomWidth;
                int parquetPrice = 5000, parquetCost = parquetPrice * roomArea;
                int layingParquetPrice = 600, layingParquetCost = roomArea * layingParquetPrice;
                roomTotalCost = parquetCost + layingParquetCost;
            }

            int kitchenTotalCost;

            {
                int kitchenLength = 4;
                int kitchenWidth = 3, kitchenArea = kitchenLength * kitchenWidth;
                int tilePrice = 4000;
                int layingTilesPrice = 700;
                int tileCoast = kitchenArea * tilePrice;
                int layingTilesCost = kitchenArea * layingTilesPrice;
                kitchenTotalCost = tileCoast + layingTilesCost;
            }

            int totalCost = roomTotalCost + kitchenTotalCost;

            Console.WriteLine(totalCost);

        }
    }
}
