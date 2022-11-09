namespace SlotMachine.Models
{
    public class Slot
    {
        public string Symbol { get; set; }

        public int Value { get; set; }

        public int Weight { get; set; }


        public Slot(string symbol, int value, int weight)
        {
            Symbol = symbol;
            Value = value;
            Weight = weight;
        }
    }
}
