namespace GranjaAvicolaD.app.Dominio
{
     /// <summary>Class <c>Galpon</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class Galpon
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public int NumeroGallinas { get; set; }
        public string Ubicacion { get; set; }
        public DatosInicioSesion Operario_id { get; set; }
        public DatosInicioSesion Veterinario_id { get; set; }
    }
}