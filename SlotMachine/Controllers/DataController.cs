using SlotMachine.Data;
using SlotMachine.Models;

namespace SlotMachine.Controllers
{
    public class DataController
    {
        public static void DataStart()
        {
            SlotsData.Slots = new List<Slot>();
            SlotsData.Slots.Add(new Slot("A", 100, 1));
            SlotsData.Slots.Add(new Slot("B", 50, 2));
            SlotsData.Slots.Add(new Slot("C", 25, 4));
            SlotsData.Slots.Add(new Slot("D", 20, 8));
            SlotsData.Slots.Add(new Slot("E", 15, 12));
            SlotsData.Slots.Add(new Slot("F", 10, 16));
            SlotsData.Slots.Add(new Slot("G", 5, 20));
            SlotsData.Slots.Add(new Slot("H", 1, 24));
            SlotsData.Reels = new List<string>();

            foreach (Slot item in SlotsData.Slots)
            {
                for (int i = 0; i < item.Weight; i++)
                {
                    SlotsData.Reels.Add(item.Symbol);
                }
            }
        }
    }
}
