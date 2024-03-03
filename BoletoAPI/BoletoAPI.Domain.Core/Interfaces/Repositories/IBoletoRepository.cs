using BoletoAPI.Domain.Entities;

namespace BoletoAPI.Domain.Core.Interfaces.Repositories;

public interface IBoletoRepository
{
    string RetornarHtml(DadosBoleto dadosBoleto, DadosBeneficiario dadosBeneficiario, ContaBancaria contaBancaria, Sacado sacado, DadosEndereco endereco);
}