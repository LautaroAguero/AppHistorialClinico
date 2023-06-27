using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionHistorialClinico
{
    public class Turno
    {
        private Paciente _paciente;
        private DateTime _fecha;
        private DateTime _hora;
        private String _descripcion;

        public DateTime fecha { get => _fecha; set => _fecha = value; }
        public DateTime hora { get => _hora; set => _hora = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public Paciente Paciente { get => _paciente; set => _paciente = value; }
    }
}
