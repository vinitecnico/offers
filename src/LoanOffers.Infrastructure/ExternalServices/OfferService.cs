using System.Threading.Tasks;
using LoanOffers.Domain.Models;
using LoanOffers.Domain.Services;

namespace LoanOffers.Infrastructure.ExternalServices
{
    public class OfferService : IOfferService
    {
        public async Task<GetOfferByCpfResult> GetOfferByCpf(string cpf)
        {
            var result = new GetOfferByCpfResult
            {
                Cpf = "123456",
                Name = "jose testador"
            };
            
            return result;
        }
    }
}