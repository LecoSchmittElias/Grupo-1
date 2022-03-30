using AutenticacaoGrupoUm.Entities;

namespace AutenticacaoGrupoUm.Repositories
{
    public interface IUsuarioRepository
    {
        bool GetByLoginSenha(UsuarioEntity usuario);
    }
}
