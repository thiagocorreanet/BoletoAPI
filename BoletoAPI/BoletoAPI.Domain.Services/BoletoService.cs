using BoletoAPI.Domain.Core.Interfaces.Repositories;
using BoletoAPI.Domain.Core.Interfaces.Services;
using BoletoAPI.Domain.Entities;

namespace BoletoAPI.Domain.Services;

public class BoletoService : IBoletoService
{
    private readonly IBoletoRepository _boletoRepository;
    
    public BoletoService(IBoletoRepository boletoRepository)
    {
        _boletoRepository = boletoRepository;
    }
    public async Task<string> GerarHtmlBoletoAsync(DadosBoleto dadosBoleto, DadosBeneficiario dadosBeneficiario, ContaBancaria contaBancaria,
        Sacado sacado, DadosEndereco endereco)
    {
        return await Task.Run(() =>  _boletoRepository.RetornarHtml(dadosBoleto, dadosBeneficiario, contaBancaria, sacado, endereco));
    }
}