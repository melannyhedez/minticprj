using System.Collections.Generic;
using System.Linq;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia
{
    /// <summary>
    /// Referencia al contexto del Usuario
    /// </summary>
    private readonly AppContext _appContext;
    /// <summary>
    /// Metodo Constructor Utiiza 
    /// Inyeccion de dependencias para indicar el contexto a utilizar
    /// </summary>
    /// <param name="appContext"></param>//

    public RepositorioUsuario(AppContext appContext)
    {
        _appContext = appContext;
    }

    Usuario IRepositorioUsuario.AddUsuario(Usuario usuario)
    {
        var usuarioAdicionado = _appContext.Usuarios.Add(usuario);
        _appContext.SaveChanges();
        return usuarioAdicionado.Entity;
    }

    void IRepositorioUsuario.DeleteUsuario(int idUsuario)
    {
        var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(p => p.Id == idUsuario);
        if (usuarioEncontrado == null)
            return;
        _appContext.Usuarios.Remove(usuarioEncontrado);
        _appContext.SaveChanges();
    }

    IEnumerable<Usuario> IRepositorioUsuario.GetAllUsuarios()
    {
        return _appContext.Usuarios;
    }

    Usuario IRepositorioUsuario.GetUsuario(int idUsuario)
    {
        return _appContext.Usuarios.FirstOrDefault(p => p.Id == idUsuario);
    }

    Usuario IRepositorioUsuario.UpdateUsuario(Usuario usuario)
    {
        var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(p => p.Id == usuario.Id);
        if (usuarioEncontrado != null)
        {
            usuarioEncontrado.Nombre = usuario.Nombre;
            usuarioEncontrado.Correo = usuario.Correo;
            usuarioEncontrado.Telefono = usuario.Telefono;
            usuarioEncontrado.Rol = usuario.Rol;

            _appContext.SaveChanges();


        }
        return usuarioEncontrado;
    }

    Rol IRepositorioUsuario.AsignarRol(int idUsuario, int idEnumRol)
    {
        var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(p => p.Id == idUsuario);
        if (usuarioEncontrado != null) {
            usuarioEncontrado.Rol = idEnumRol;
            _appContext.SaveChanges();
            return usuarioEncontrado;
        }
        return null;
    }

}