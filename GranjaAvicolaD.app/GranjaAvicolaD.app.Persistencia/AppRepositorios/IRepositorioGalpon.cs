using System;
using System.Collections.Generic;
using System.Linq;
using GranjaAvicolaD.app.Dominio;

namespace GranjaAvicolaD.app.Persistencia
{
    public interface IRepositorioGalpon
    {
        IEnumerable<Galpon> GetAllGalpones();
        Galpon AddGalpon(Galpon galpon);
        Galpon UpdateGalpon(Galpon galpon);
        void DeleteGalpon(int idGalpon);
        Galpon GetGalpon(int idGalpon);
        Usuario AsignarOperario(int idGalpon, int idUsuario);
        Usuario AsignarVeterinario(int idGalpon, int idUsuario);
    }
}