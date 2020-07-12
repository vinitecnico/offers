using System.Threading;
using System.Threading.Tasks;
using LoanOffers.Domain.Models;
using LoanOffers.Domain.Handlers;
using LoanOffers.Domain.Services;
using Moq;
using Xunit;
using LoanOffers.Domain.Commands;

namespace LoanOffers.Tests.Unit.Domain
{
    public class OfferHandlerTests
    {
        [Fact]
        public async Task ShoudReturnCustomer()
        {
            var expectedResult = new GetOfferByCpfResult
            {
                Cpf = "123456",
                Name = "jose testador"
            };

            var offerServiceMock = new Mock<IOfferService>();
            offerServiceMock.Setup(x => x.GetOfferByCpf(It.IsAny<string>())).ReturnsAsync(expectedResult);

            var getOfferByCpfHandler = new GetOfferByCpfHandler(offerServiceMock.Object);
            var result = await getOfferByCpfHandler.Handle(new GetOfferByCpfCommand { CPF = "123456" }, CancellationToken.None);

            Assert.Equal(expectedResult.Cpf, result.Cpf);
        }
    }
}