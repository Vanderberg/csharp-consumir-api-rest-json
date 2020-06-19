using System.Threading.Tasks;
using Refit;
namespace Rest.Cep
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);         
    }
}