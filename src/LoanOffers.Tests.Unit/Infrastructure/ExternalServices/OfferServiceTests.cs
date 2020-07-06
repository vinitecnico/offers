using System.Threading;
using System.Threading.Tasks;
using LoanOffers.Domain.Models;
using LoanOffers.Infrastructure.ExternalServices;
using Xunit;

namespace LoanOffers.Tests.Unit.Infrastructure.ExternalServices
{
    public class OfferServiceTests
    {
        [Fact]
        public async Task ShoudReturnCustomer()
        {
            var expectedResult = new GetOfferByCpfResult
            {
                Cpf = "123456",
                Name = "jose testador"
            };

            var offerService = new OfferService();
            var result = await offerService.GetOfferByCpf("123456");

            Assert.Equal(expectedResult.Cpf, result.Cpf);
        }
    }
}