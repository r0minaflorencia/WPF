using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GrupoN.Models { 
	public class ProfesorModel()
	{
        
            // encapsulamiento:
            private int _id;
            private string _nombre;
            private string _apellido;
            private string _especialidad;

            public int Id
            {
                get { return _id; }
                set
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("El Id debe ser mayor a 0.");
                    }
                    _id = value;
                }
            }

            public string Nombre
            {
                get { return _nombre; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentNullException(nameof(Nombre), "El nombre no puede estar vacío.");
                    }
                    _nombre = value;
                }
            }

            public string Apellido
            {
                get { return _apellido; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentNullException(nameof(Apellido), "El apellido no puede estar vacío.");
                    }
                    _apellido = value;
                }
            }

            public string Especialidad
            {
                get { return _especialidad; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentNullException(nameof(Especialidad), "La especialidad no puede estar vacía.");
                    }
                    _especialidad = value;
                }
            }

            public override string? ToString()
            {
                return base.ToString();
            }
        }

    }
}
