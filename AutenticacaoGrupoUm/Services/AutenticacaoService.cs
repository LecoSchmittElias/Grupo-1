using AutenticacaoGrupoUm.Dto;
using AutenticacaoGrupoUm.Entities;
using AutenticacaoGrupoUm.Repositories;

namespace AutenticacaoGrupoUm.Services
{
    public class AutenticacaoService: IAutenticacaoService
    {
        private readonly IUsuarioRepository _UsuarioRepository;

        public AutenticacaoService(IUsuarioRepository usuarioRepository)
        {
            _UsuarioRepository = usuarioRepository;
        }

       public RetornoDto ValidarEntrada(InputDto inputDto)
        {
            var usuario = new UsuarioEntity()
            {
                Login = inputDto.Login,
                Senha = inputDto.Senha
            };

           bool Situacao = _UsuarioRepository.GetByLoginSenha(usuario);

            if (Situacao == true)
            {
                var RetornoAutenticacao = new RetornoAutenticacaoDto() 
                { 
                Login = inputDto.Login,
                Senha = inputDto.Senha     
                };

                return new RetornoDto{ StatusCode = 200, Retorno = RetornoAutenticacao };
            }
            return new RetornoDto { StatusCode = 400, Retorno =  new ErroDto {MensagemErro = "Deu pau" } };
        }

    }
}
