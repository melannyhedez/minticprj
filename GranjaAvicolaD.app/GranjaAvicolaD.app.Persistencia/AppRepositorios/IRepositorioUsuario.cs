using System;
using System.Collections.Generic;
using System.Linq;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia
{
    public interface IRepositorioUsuario
    {
        IEnumerable<Usuario> GetAllUsuarios();
        Usuario AddUsuario(Usuario usuario);
        Usuario UpdateUsuario(Usuario Usuario);
        void DeleteUsuario(int idUsuario);
        Usuario GetUsuario(int idUsuario);
        Rol AsignarRol(int idUsuario, int idEnumRol);
    }
}