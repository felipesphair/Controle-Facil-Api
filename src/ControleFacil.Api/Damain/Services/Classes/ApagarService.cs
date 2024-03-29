using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ControleFacil.Api.Contract.Apagar;
using ControleFacil.Api.Damain.Models;
using ControleFacil.Api.Damain.Repository.Interfaces;
using ControleFacil.Api.Damain.Services.Interfaces;
using ControleFacil.Api.Exceptions;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ControleFacil.Api.Damain.Services.Classes
{
    public class ApagarService : IService<ApagarRequestContract, ApagarResponseContract, long>
    {
        private readonly IApagarRepository _apagarRepository;

        private readonly IMapper _mapper;


        public ApagarService(IApagarRepository apagarRepository, IMapper mapper)
        {
             _apagarRepository = apagarRepository;
             _mapper = mapper;
        }

        public async Task<ApagarResponseContract> Adicionar(ApagarRequestContract entidade, long idUsuario)
        {

           Validar(entidade);
           Apagar apagar = _mapper.Map<Apagar>(entidade);
           
           apagar.DataCadastro = DateTime.Now;

           apagar.IdUsuario = idUsuario;

           apagar = await _apagarRepository.Adicionar(apagar);

           return _mapper.Map<ApagarResponseContract>(apagar);



        }

        public async Task<ApagarResponseContract> Atualizar(long id, ApagarRequestContract entidade, long idUsuario)
        {
            
           Validar(entidade);
            Apagar apagar = await ObterPorIdVinculadoAoIdUsuario(id, idUsuario);

            /*apagar.Descricao = entidade.Descricao;
            apagar.Observacao = entidade.Observacao;
            apagar.ValorOriginal = entidade.ValorOriginal;
            apagar.ValorPago = entidade.ValorOriginal;
            apagar.DataPagamento = entidade.DataPagamento;
            apagar.DataReferencia = entidade.DataReferencia;
            apagar.DataVencimento = entidade.DataVencimento;
            apagar.IdNaturezaDeLancamento = entidade.IdNaturezaDeLancamento;*/
            var contrato = _mapper.Map<Apagar>(entidade);
            contrato.IdUsuario = apagar.IdUsuario;
            contrato.Id =  apagar.Id;
            contrato.DataCadastro = apagar.DataCadastro;

            apagar = await _apagarRepository.Atualizar(apagar);

            return _mapper.Map<ApagarResponseContract>(apagar);
           
        }

        public async Task Inativar(long id, long idUsuario)
        {
            Apagar apagar = await ObterPorIdVinculadoAoIdUsuario(id, idUsuario);
            await _apagarRepository.Deletar(apagar);
        }

        public async Task<IEnumerable<ApagarResponseContract>> Obter(long idUsuario)
        {
            var titulosApagar = await _apagarRepository.ObterPeloIdUsuario(idUsuario);

            return titulosApagar.Select(titulo => _mapper.Map<ApagarResponseContract>(titulo));
        }

        public async Task<ApagarResponseContract> Obter(long id, long idUsuario)
        {
            Apagar apagar = await ObterPorIdVinculadoAoIdUsuario(id, idUsuario);
            return _mapper.Map<ApagarResponseContract>(apagar);
        }

        private async Task<Apagar> ObterPorIdVinculadoAoIdUsuario(long id, long idUsuario) {
            var apagar = await _apagarRepository.Obter(id);
            if  (apagar is null  || apagar.IdUsuario != idUsuario ) 
                throw new NotFoundException($"Não foi encontrada nenhum titulo apagar de lançamento pelo id {id}");
            
            return apagar;
        }

        private void Validar(ApagarRequestContract entidade) {
            if(entidade.ValorOriginal < 0 || entidade.ValorPago < 0) {
                throw new BadRequestException("Os Campos ValorOriginal e ValorPago não podem ser negativos.");
            } 
        }
    }


}