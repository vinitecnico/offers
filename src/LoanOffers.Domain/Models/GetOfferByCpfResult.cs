using Newtonsoft.Json;

namespace LoanOffers.Domain.Models
{
    public class GetOfferByCpfResult
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cpf")]
        public string Cpf { get; set; }
    }
}