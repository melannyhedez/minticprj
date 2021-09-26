using System;
namespace GranjaAvicolaD.app.Dominio
{
     /// <summary>Class <c>Persona</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class Registro
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario Usuario_id { get; set; }
        

    }
}