using Refit;
using SistemaDeTarefas.Integracao.Reponse;

namespace SistemaDeTarefas.Integracao.Refit
{
    public interface IViaCepIntegracao
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
    }
}
