namespace GranjaAvicolaD.app.Dominio
{
     /// <summary>Class <c>Persona</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class DatosInicioSesion
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Pasword { get; set; }
        public Usuario Usuario_id { get; set; }
        public Roles Rol { get; set; }
    }
}