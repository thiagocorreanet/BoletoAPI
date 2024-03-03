using BoletoAPI.Domain.Entities;

namespace BoletoAPI.Domain.Core.Interfaces.Services;

public interface IBoletoService
{
    Task<string> GerarHtmlBoletoAsync(DadosBoleto dadosBoleto, DadosBeneficiario dadosBeneficiario, ContaBancaria contaBancaria, Sacado sacado, DadosEndereco endereco);
}