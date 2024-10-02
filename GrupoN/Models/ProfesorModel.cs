using System;

namespace GrupoN.Models { 
	public class ProfesorModel()
	{
        // atributos + get&set
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }

        // Constructor por defecto
        public Profesor() { }

        // Constructor con parámetros
        public Profesor(int Id, string Nombre, string Apellido, string Especialidad)
        {
            Id = Id;    
            Nombre = Nombre;
            Apellido = Apellido;
            Especialidad = Especialidad;
        }

        // Método para mostrar información de la persona
        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}, Apellido: {Apellido}, Especialidad: {Especialidad}");
        }

    }
}
