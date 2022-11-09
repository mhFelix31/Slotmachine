using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using SlotMachine.Data;
using SlotMachine.Models;
using System.Security.Cryptography;

namespace SlotMachine.Controllers
{
    [ApiController]
    [Route("play")]

    public class GameController : ControllerBase
    {
        [HttpPost]
        public IActionResult Play([FromBody] Payload payload)
        {
            if (payload.bet <= 0)
                return NoContent();
            return Ok(CreateResponse(payload.bet));
        }



        private Response CreateResponse(int bet)
        {
            List<Slot> DrawnSlot = new List<Slot>();
            List<string> DrawnSymbols = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Slot slot = RandomDrawnSlot();
                DrawnSlot.Add(slot);
                DrawnSymbols.Add(slot.Symbol);

            }

            int prize = 0;

            if (DrawnSlot[0] == DrawnSlot[1] && DrawnSlot[0] == DrawnSlot[2])
            {
                prize = bet * DrawnSlot[0].Value;
            }

            Response response = new Response(DrawnSymbols,prize);

            return response;
        }

        private Slot RandomDrawnSlot()
        {
            
            int RNG = RandomNumberGenerator.GetInt32(SlotsData.Reels.Count-1);
            for (int i = 0; i < SlotsData.Slots.Count; i++)
            {
                if (SlotsData.Reels[RNG] == SlotsData.Slots[i].Symbol)
                {
                    return SlotsData.Slots[i];
                }

            }
            return null;
        }



    }
}
