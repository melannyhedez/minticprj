namespace GranjaAvicolaD.app.Dominio
{
     /// <summary>Class <c>Persona</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class Historia
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public float Temperatura { get; set; }
        public float NivelAgua { get; set; }
        public float CantidadAlimento { get; set; }
        public int GallinasEnfermasPorCuarentena { get; set; }
        public Galpon Galpon_id { get; set; }
        public Usuario Usuario_id { get; set; }
    }
}