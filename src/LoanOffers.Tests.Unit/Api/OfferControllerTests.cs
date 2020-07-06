using System.Threading;
using System.Threading.Tasks;
using LoanOffers.Api.Controllers;
using LoanOffers.Domain.Commands;
using LoanOffers.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace LoanOffers.Tests.Unit.Api
{
    public class OfferControllerTests
    {
        [Theory]
        [InlineData("123456")]
        public async Task ShouldReturnCustomer(string cpf){
            var expectedResult = new GetOfferByCpfResult
            {
                Cpf = "123456",
                Name = "jose testador"
            };

            var mediatorMock = new Mock<IMediator>();
            mediatorMock.Setup(x => x.Send(It.IsAny<GetOfferByCpfCommand>(), CancellationToken.None)).ReturnsAsync(expectedResult);

            var controller = new WeatherForecastController(mediatorMock.Object);
            var result = await controller.GetOfferByCpf(new GetOfferByCpfCommand {Cpf = "123456"});

            var okObjectResult = result as OkObjectResult;
            var okResult = okObjectResult.Value as GetOfferByCpfResult;

            Assert.NotNull(okResult);
            Assert.Equal(expectedResult.Cpf, okResult.Cpf);
        }
    }
}