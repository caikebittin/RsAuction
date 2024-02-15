using Microsoft.AspNetCore.Mvc;
using RsAuction.Entities;
using RsAuction.UseCases.Auctions.GetCurrent;

namespace RsAuction.Controllers;

public class AuctionController : RsAuctionBaseController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction([FromServices] GetCurrentAuctionUseCase useCase)
    {
        var result = useCase.Execute();

        if (result == null)
            return NoContent();

        return Ok(result);
    }
}

