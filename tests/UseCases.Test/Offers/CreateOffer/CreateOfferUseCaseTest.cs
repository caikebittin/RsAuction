using Bogus;
using FluentAssertions;
using Moq;
using RsAuction.Communication.Requests;
using RsAuction.Contracts;
using RsAuction.Entities;
using RsAuction.Services;
using RsAuction.UseCases.Auctions.GetCurrent;
using RsAuction.UseCases.Offers.CreateOffer;
using Xunit;

namespace UseCases.Test.Offers.CreateOffer;
public class CreateOfferUseCaseTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void Sucess(int itemId)
    {
        //ARRANGE - Inicializa oque precisa.
        var request = new Faker<RequestCreateOfferJson>()
            .RuleFor(request => request.Price, f => f.Random.Decimal(1, 700)).Generate();

        var offerRepository = new Mock<IOfferRepository>();
        var loggedUser = new Mock<ILoggedUser>();
        loggedUser.Setup(i => i.User()).Returns(new User());

        var useCase = new CreateOfferUseCase(loggedUser.Object ,offerRepository.Object);

        //ACT - Executa oque precisa.
        var act = () => useCase.Execute(itemId, request);

        //ASSERT - Verifica se o resultado retornado é o esperado.
        act.Should().NotThrow();


    }
}
