using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ControleFacil.Api.Contract.Usuario;
using ControleFacil.Api.Damain.Models;
using ControleFacil.Api.Damain.Repository.Classes;
using ControleFacil.Api.Damain.Repository.Interfaces;
using ControleFacil.Api.Damain.Services.Interfaces;
using ControleFacil.Api.Exceptions;

namespace ControleFacil.Api.Damain.Services.Classes
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        private readonly IMapper _mapper;

        private readonly TokenService _tokenService;

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper,TokenService tokenService)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _tokenService = tokenService;
        }

        public async Task<UsuarioResponseContract> Adicionar(UsuarioRequestContract entidade, long idUsuario)
        {
            /*
            Usuario usuario = new Usuario {
               Email = entidade.Email, 
               Senha = entidade.Senha, 
               DataCadastro = DateTime.Now,
               DataInativacao = entidade.DataInativacao
            };
            */
            
            //await _usuarioRepository.Adicionar();

            /*
            return new UsuarioResponseContract
            {
                Id = usuario.Id,
                Email = usuario.Email,
                Senha = Usuario.Senha,
                DataCadastro = DateTime.Now,
                DataInativacao = entidade.DataInativacao
            }*/

            var usuario = _mapper.Map<Usuario>(entidade);
            usuario.Senha = GerarHashSenha(usuario.Senha);
            usuario.DataCadastro = DateTime.Now;
            usuario = await _usuarioRepository.Adicionar(usuario);

            return _mapper.Map<UsuarioResponseContract>(usuario);

        }

 

        public async Task<UsuarioResponseContract> Atualizar(long id, UsuarioRequestContract entidade, long idUsuario)
        {
            _ = await Obter(id) ?? throw new NotFoundException("Usuario não encontrado para atualização.");
            var usuario = _mapper.Map<Usuario>(entidade);
            usuario.Id = id;
            usuario.Senha = GerarHashSenha(entidade.Senha);
            usuario = await _usuarioRepository.Atualizar(usuario);
            return _mapper.Map<UsuarioResponseContract> (usuario);

            

        }

        public async Task<UsuarioLoginResponseContract> Autenticar(UsuarioLoginRequestContract usuarioLoginRequest)
        {
            UsuarioResponseContract usuario = await Obter(usuarioLoginRequest.Email);
            var  hashSenha = GerarHashSenha(usuarioLoginRequest.Senha);
            if (usuario == null || usuario.Senha != hashSenha) {
                throw new AuthenticationException("USUARIO OU SENHA INVÁLIDO(S)!");
            }
            return new UsuarioLoginResponseContract {
                Id=usuario.Id,
                Email=usuario.Email,
                Token = _tokenService.GerarToken(_mapper.Map<Usuario>(usuario))
            };
        }

        public async Task Inativar(long id, long idUsuario)
        {
            var usuario = await _usuarioRepository.Obter(id) ?? throw new NotFoundException("Usuario não encontrado para inativação.");
            await _usuarioRepository.Deletar(_mapper.Map<Usuario>(usuario));

        }

        public async Task<IEnumerable<UsuarioResponseContract>> Obter(long idUsuario)
        {
            var usuarios = await _usuarioRepository.Obter();
            return usuarios.Select(usuario =>  _mapper.Map<UsuarioResponseContract>(usuario));
        }

        public async Task<UsuarioResponseContract> Obter(long id, long idUsuario)
        {
             var usuario = await _usuarioRepository.Obter(id);
            return  _mapper.Map<UsuarioResponseContract>(usuario);
        }

        public async Task<UsuarioResponseContract> Obter(string email)
        {
            var usuario = await _usuarioRepository.Obter(email);
            return  _mapper.Map<UsuarioResponseContract>(usuario);
        }

       private string GerarHashSenha(string senha)
        {
            string hashSenha;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] byteSenha = Encoding.UTF8.GetBytes(senha);
                byte[] byteHashSenha = sha256.ComputeHash(byteSenha);
                // Convertendo o array de bytes em uma string hexadecimal
                StringBuilder builder = new StringBuilder();
                foreach (byte b in byteHashSenha)
                {
                    builder.Append(b.ToString("x2"));
                }
                hashSenha = builder.ToString();
            }
            return hashSenha;
        }
    }
}