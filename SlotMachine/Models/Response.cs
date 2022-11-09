namespace SlotMachine.Models
{
    public class Response
    {
        public List<string> symbols { get; private set; }

        public int won { get; private set; }


        public Response(List<string> symbols, int won)
        {
            this.symbols = symbols;
            this.won = won;
        }
    }



}
