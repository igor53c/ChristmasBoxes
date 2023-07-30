using System;
using System.Collections.Generic;
using System.Linq;

namespace ChristmasBoxesImplementation
{
    public static class ChristmasBoxService
    {
        public static IEnumerable<ChristmasBox> GetShuffledPresentList(this List<ChristmasBox> boxList)
        {
            // Sort the boxes in descending order
            boxList = boxList.OrderByDescending(box => box.Weight).ToList();

            // Create a new list for the result
            var result = new List<ChristmasBox>();

            // Distribute the boxes
            int i = 0;
            while (boxList.Count > 0)
            {
                // Calculate the recipient (0 = Gilfi, 1 = Jordi, 2 = Trixi, 3 = Balbo)
                int recipient = i % 4;

                if (recipient == 1) // Jordi
                {
                    // Add the heaviest remaining box to the result
                    result.Add(boxList[0]);
                    boxList.RemoveAt(0);
                }
                else
                {
                    // Add the lightest remaining box to the result
                    result.Add(boxList[boxList.Count - 1]);
                    boxList.RemoveAt(boxList.Count - 1);
                }

                i++;
            }

            return result;
        }

    }
}
