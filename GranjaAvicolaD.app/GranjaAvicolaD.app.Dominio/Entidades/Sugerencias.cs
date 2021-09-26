namespace GranjaAvicolaD.app.Dominio
{
     /// <summary>Class <c>Persona</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class Sugerencias
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public Usuario Usuario_id { get; set; }
        public string Descripcion { get; set; }
    }
}