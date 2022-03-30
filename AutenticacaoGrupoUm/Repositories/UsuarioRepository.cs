using AutenticacaoGrupoUm.Entities;

namespace AutenticacaoGrupoUm.Repositories
{
    public class UsuarioRepository: IUsuarioRepository
    {
        public List<UsuarioEntity> Usuarios = new List<UsuarioEntity>()
        {
            new UsuarioEntity()
            {
                Login = "Jubileu",
                Senha = "TioSamSocorro"
            },
            new UsuarioEntity()
            {
                Login = "Mauricio",
                Senha = "NaoConsigoLerNada"
            },
            new UsuarioEntity()
            {
                Login = "Leco",
                Senha = "BolinhaDeGorfe"
            },
            new UsuarioEntity()
            {
                Login = "Alexandre",
                Senha = "E-La-vamos-nos"
            },
            new UsuarioEntity()
            {
                Login = "Joao",
                Senha = "BoluDeMorangu"
            },
        };

        public bool GetByLoginSenha(UsuarioEntity usuario) => Usuarios.Find(x => x.Login == usuario.Login && x.Senha == usuario.Senha) == null? false: true;
    }
}
