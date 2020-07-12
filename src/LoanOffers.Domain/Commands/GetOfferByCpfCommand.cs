using MediatR;
using LoanOffers.Domain.Models;

namespace LoanOffers.Domain.Commands
{
    public class GetOfferByCpfCommand : IRequest<GetOfferByCpfResult>
    {
        public string CPF { get; set; }
    }
}