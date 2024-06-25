using Refit;
using SistemaDeTarefas.Integracao.Reponse;

namespace SistemaDeTarefas
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json")]

        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
    }
}