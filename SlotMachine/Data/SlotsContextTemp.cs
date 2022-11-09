using SlotMachine.Models;

namespace SlotMachine.Data
{
    public class SlotsContextTemp
    {
        public static List<Slot> Slots { get; set; }

        public static List<string> Reels { get; private set; }

        public static void TemporaryStart()
        {
            Slots = new List<Slot>();
            Slots.Add(new Slot("A",     100,    1));
            Slots.Add(new Slot("B",     50,     2));
            Slots.Add(new Slot("C",     25,     4));
            Slots.Add(new Slot("D",     20,     8));
            Slots.Add(new Slot("E",     15,     12));
            Slots.Add(new Slot("F",     10,     16));
            Slots.Add(new Slot("G",     5,      20));
            Slots.Add(new Slot("H",     1,      24));
            Reels = new List<string>();

            foreach (Slot item in Slots)
            {
                for (int i = 0; i < item.Weight; i++)
                {
                    Reels.Add(item.Symbol);
                }
            }
        }

    }
}
