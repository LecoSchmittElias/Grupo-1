using AutenticacaoGrupoUm.Dto;

namespace AutenticacaoGrupoUm.Services
{
    public interface IAutenticacaoService
    {
        RetornoDto ValidarEntrada(InputDto inputDto);

    }
}
