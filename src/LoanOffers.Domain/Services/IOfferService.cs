using System.Threading.Tasks;
using LoanOffers.Domain.Models;

namespace LoanOffers.Domain.Services
{
    public interface IOfferService
    {
         Task<GetOfferByCpfResult> GetOfferByCpf(string cpf);
    }
}