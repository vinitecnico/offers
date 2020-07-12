using System.Threading;
using System.Threading.Tasks;
using LoanOffers.Domain.Commands;
using LoanOffers.Domain.Models;
using LoanOffers.Domain.Services;
using MediatR;

namespace LoanOffers.Domain.Handlers
{
    public class GetOfferByCpfHandler : IRequestHandler<GetOfferByCpfCommand, GetOfferByCpfResult>
    {
        private readonly IOfferService _offerService;
        public GetOfferByCpfHandler(IOfferService offerService)
        {
            _offerService = offerService;
        }

        public async Task<GetOfferByCpfResult> Handle(GetOfferByCpfCommand request, CancellationToken cancellationToken)
        {
            return await _offerService.GetOfferByCpf(request.CPF);
        }
    }
}