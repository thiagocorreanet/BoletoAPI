using AutoMapper;
using BoletoAPI.Application.DTOs;
using BoletoAPI.Application.Interfaces;
using BoletoAPI.Domain.Core.Interfaces.Services;
using BoletoAPI.Domain.Entities;

namespace BoletoAPI.Application;

public class BoletoApplicationService : IBoletoApplicationService
{
    private readonly IBoletoService _boletoService;
    private readonly IMapper _mapper;

    public BoletoApplicationService(IMapper mapper, IBoletoService boletoService)
    {
        _mapper = mapper;
        _boletoService = boletoService;
    }

    public async Task<string> GerarHTMLBoletoAsync(DadosBoletoDTO dadosBoletoDTO)
    {
        var mapearDadosBoleto = _mapper.Map<DadosBoleto>(dadosBoletoDTO);
        var mapearDadosBeneficiario = _mapper.Map<DadosBeneficiario>(dadosBoletoDTO.BeneficiarioDTO);
        var mapearContaBancaria = _mapper.Map<ContaBancaria>(dadosBoletoDTO.BeneficiarioDTO.ContaBancariaDTO);
        var mapearDadosSacado = _mapper.Map<Sacado>(dadosBoletoDTO.SacadoDTO);
        var mapearDadosEndereco = _mapper.Map<DadosEndereco>(dadosBoletoDTO.SacadoDTO.EnderecoDTO);

        return await _boletoService.GerarHtmlBoletoAsync(mapearDadosBoleto, mapearDadosBeneficiario, mapearContaBancaria, mapearDadosSacado, mapearDadosEndereco);
    }
}