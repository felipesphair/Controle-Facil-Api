
using System.ComponentModel.DataAnnotations;
using ControleFacil.Api.Contract.Areceber;
using ControleFacil.Api.Damain.Services.Interfaces;
using ControleFacil.Api.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleFacil.Api.Controllers
{
    [ApiController]
    [Route("areceber")]
    public class AreceberController :  BaseController
    {

        private readonly IService<AreceberRequestContract, AreceberResponseContract, long> _areceberService;

        public AreceberController(IService<AreceberRequestContract, AreceberResponseContract, long> areceberService)
        {
            _areceberService = areceberService;
            
        }


        [HttpPost]
        [Authorize]

        public async  Task<ActionResult> Adicionar(AreceberRequestContract contrato) {
            try {
                _idUsuario = ObterIdUsuarioLogado();
                return Created("", await _areceberService.Adicionar(contrato, _idUsuario));

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
                return Ok( await _areceberService.Obter(_idUsuario));

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
                return Ok( await _areceberService.Obter(id, _idUsuario));

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

        public async  Task<ActionResult> Atualizar(long id, AreceberRequestContract contrato) {
            try {
                _idUsuario = ObterIdUsuarioLogado();
                return Ok( await _areceberService.Atualizar(id, contrato, _idUsuario));

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
                 await _areceberService.Inativar(id, _idUsuario);
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