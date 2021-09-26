namespace GranjaAvicolaD.app.Dominio
{
     /// <summary>Class <c>Usuario</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class Usuario
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        // nombre del usuario registrado
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

    }
}

// Video explicativo 
//https://www.youtube.com/watch?v=6peLLyl3L7c&t=1s              instalacion de base de datos y migracion
//https://www.youtube.com/watch?v=den0-F0gbls
//https://www.youtube.com/watch?v=XpulbHt5zZ0