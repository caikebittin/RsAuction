using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;
using RsAuction.Communication.Requests;
using RsAuction.Filters;
using RsAuction.UseCases.Offers.CreateOffer;

namespace RsAuction.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : RsAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute] int itemId, [FromBody] RequestCreateOfferJson request, [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemId, request);
        
        return Created(string.Empty, id);
    }
}
