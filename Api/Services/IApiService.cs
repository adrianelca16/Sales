using Modelos.Responses;

namespace Api.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string servicePrefix, string controller);

    }
}
