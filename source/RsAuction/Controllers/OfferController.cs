using Microsoft.AspNetCore.Mvc;
using RsAuction.Communication.Requests;

namespace RsAuction.Controllers;

public class OfferController : RsAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute] int itemId, [FromBody] RequestCreateOfferJson request)
    {
        return Created();
    }
}
