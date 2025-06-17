using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using ClinicaEstetica.DAL;
using ClinicaEstetica.DTO;

namespace ClinicaEstetica.BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL usuarioDAL = new UsuarioDAL();

        public UsuarioDTO AutenticarUsuario(string email, string senha)
        {
            return usuarioDAL.Autenticar(email, senha);
        }
        public List<UsuarioDTO> ListarTodosUsuarios()
        {
            return usuarioDAL.ListarTodos();
        }
        public List<TipoUsuarioDTO> GetTipoUsuario()
        {
            return usuarioDAL.GetTipos();
        }

        public void CreateUsuario(UsuarioDTO usuarioDTO)
        {
            usuarioDAL.Create(usuarioDTO);
        }
        public void UpdateUsuario(UsuarioDTO usuarioDTO)
        {
            usuarioDAL.Update(usuarioDTO);
        }

        public void DeletarUsuario(int id)
        {
            usuarioDAL.Delete(id);
        }
    }

}
