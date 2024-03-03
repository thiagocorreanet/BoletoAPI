using BoletoAPI.Application.DTOs;

namespace BoletoAPI.Application.Interfaces
{
    public interface IBoletoApplicationService
    {
        Task<string> GerarHTMLBoletoAsync(DadosBoletoDTO dadosBoletoDTO);
    }
}