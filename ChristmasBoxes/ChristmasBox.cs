namespace ChristmasBoxesImplementation
{
    public class ChristmasBox
    {
        public ChristmasBox(int weight)
        {
            Weight = weight;
        }

        public int Weight { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is ChristmasBox box)
            {
                return Weight == box.Weight;
            }

            return false;
        }
    }
}
