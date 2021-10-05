using System.Collections.Generic;
using System.Linq;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia
{
    /// <summary>
    /// Referencia al contexto del Galpon
    /// </summary>
    private readonly AppContext _appContext;
    /// <summary>
    /// Metodo Constructor Utiiza 
    /// Inyeccion de dependencias para indicar el contexto a utilizar
    /// </summary>
    /// <param name="appContext"></param>//

    public RepositorioGalpon(AppContext appContext)
    {
        _appContext = appContext;
    }

    Galpon IRepositorioGalpon.Add(Galpon galpon)
    {
        var galponAdicionado = _appContext.Galpones.Add(galpon);
        _appContext.SaveChanges();
        return galponAdicionado.Entity;
    }

    void IRepositorioGalpon.DeleteGalpon(int idGalpon)
    {
        var usuarioEncontrado = _appContext.Galpones.FirstOrDefault(p => p.Id == idGalpon);
        if (usuarioEncontrado == null)
            return;
        _appContext.Galpones.Remove(usuarioEncontrado);
        _appContext.SaveChanges();
    }

    IEnumerable<Galpon> IRepositorioGalpon.GetAllGalpones()
    {
        return _appContext.Galpones;
    }

    Galpon IRepositorioGalpon.GetGalpon(int idGalpon)
    {
        return _appContext.Galpones.FirstOrDefault(p => p.Id == idGalpon);
    }

    Galpon IRepositorioGalpon.UpdateGalpon(Galpon galpon)
    {
        var usuarioEncontrado = _appContext.Galpones.FirstOrDefault(p => p.Id == galpon.Id);
        if (usuarioEncontrado != null)
        {
            usuarioEncontrado.Nombre = galpon.Nombre;
            usuarioEncontrado.Correo = galpon.Correo;
            usuarioEncontrado.Telefono = galpon.Telefono;
            usuarioEncontrado.Rol = galpon.Rol;

            _appContext.SaveChanges();


        }
        return usuarioEncontrado;
    }

    Rol IRepositorioGalpon.AsignarOperario(int idGalpon, int idUsuario)
    {
        var galponEncontrado = _appContext.Galpones.FirstOrDefault(p => p.Id == idGalpon);
        if (galponEncontrado != null) {
            var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(m => m.Id == idUsuario);
            if(usuarioEncontrado != null && usuarioEncontrado.Rol == 1)
            {
                galponEncontrado.Operario_id = usuarioEncontrado.Id;
            }
            return galponEncontrado;
        }
        return null;
    }

    Rol IRepositorioGalpon.AsignarVeterinario(int idGalpon, int idUsuario)
    {
        var galponEncontrado = _appContext.Galpones.FirstOrDefault(p => p.Id == idGalpon);
        if (galponEncontrado != null) {
            var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(m => m.Id == idUsuario);
            if(usuarioEncontrado != null && usuarioEncontrado.Rol == 0)
            {
                galponEncontrado.Veterinario_id = usuarioEncontrado.Id;
            }
            return galponEncontrado;
        }
        return null;
    }

}