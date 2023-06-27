using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionHistorialClinico
{
    public class Paciente
    {
        private int _dni;
        private String _nombre;
        private String _apellido;
        private String _direccion;
        private String _telefono;
        private String _email;        
        private String _descripcion;
        private Turno _turno;

        public Paciente() { }


        public int dni { get => _dni; set => _dni = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string apellido { get => _apellido; set => _apellido = value; }
        public string direccion { get => _direccion; set => _direccion = value; }
        public string telefono { get => _telefono; set => _telefono = value; }
        public string email { get => _email; set => _email = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public Turno Turno { get => _turno; set => _turno = value; }
    }
}
