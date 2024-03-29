using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Authentication;
using System.Threading.Tasks;
using ControleFacil.Api.Contract.NaturezaDeLancamento;
using ControleFacil.Api.Damain.Services.Interfaces;
using ControleFacil.Api.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleFacil.Api.Controllers
{
    [ApiController]
    [Route("naturezasdelancamento")]
    public class NaturezaDeLancamentoController :  BaseController
    {
        private readonly IService<NaturezaDeLancamentoRequestContract, NaturezaDeLancamentoResponseContract, long> _naturezaDeLancamentoService;

        public NaturezaDeLancamentoController(IService<NaturezaDeLancamentoRequestContract, NaturezaDeLancamentoResponseContract, long> naturezaDeLancamentoService)
        {
            _naturezaDeLancamentoService = naturezaDeLancamentoService;
            
        }


        [HttpPost]
        [Authorize]

        public async  Task<ActionResult> Adicionar(NaturezaDeLancamentoRequestContract contrato) {
            try {
                _idUsuario = ObterIdUsuarioLogado();
                return Created("", await _naturezaDeLancamentoService.Adicionar(contrato, _idUsuario));

            } catch(BadRequestException ex){
                return  BadRequest(RetornarModelBadRequest(ex));
            }
            
            catch (Exception ex) {

                return Problem(ex.Message);

            }
        }

        [HttpGet]
        [Authorize]

        public async Task<ActionResult> Obter() {
            try {
                _idUsuario = ObterIdUsuarioLogado();
                return Ok( await _naturezaDeLancamentoService.Obter(_idUsuario));

            } catch (Exception ex) {

                return Problem(ex.Message);

            }
        }

        [HttpGet]
        [Route("{id}")]
        [Authorize]

        public async Task<ActionResult> Obter(long id) {
            try {
               _idUsuario = ObterIdUsuarioLogado();
                return Ok( await _naturezaDeLancamentoService.Obter(id, _idUsuario));

            } catch(NotFoundException ex){
                return  NotFound(RetornarModelNotFound(ex));
            }
            
            
            catch (Exception ex) {

                return Problem(ex.Message);

            }
        }

        [HttpPut]
        [Route("{id}")]
        [Authorize]

        public async  Task<ActionResult> Atualizar(long id, NaturezaDeLancamentoRequestContract contrato) {
            try {
                _idUsuario = ObterIdUsuarioLogado();
                return Ok( await _naturezaDeLancamentoService.Atualizar(id, contrato, _idUsuario));

            } catch(NotFoundException ex){
                return  NotFound(RetornarModelNotFound(ex));
            }
            
            catch(BadRequestException ex){
                return  BadRequest(RetornarModelBadRequest(ex));
            }
            catch (Exception ex) {

                return Problem(ex.Message);

            }
        }
        
        [HttpDelete]
        [Route("{id}")]
        [Authorize]

        public async  Task<ActionResult> Deleta(long id) {
            try {
                 _idUsuario = ObterIdUsuarioLogado();
                 await _naturezaDeLancamentoService.Inativar(id, _idUsuario);
                 return NoContent();

            } catch(NotFoundException ex){
                return  NotFound(RetornarModelNotFound(ex));
            }
            
            catch (Exception ex) {

                return Problem(ex.Message);

            }
        }

    }
}