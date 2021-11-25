using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9_ABMS
{
    public class Alumno
    {
        public Alumno(long legajo)
        {
            this.Legajo = legajo;
        }

        public Alumno(string linea)
        {
            string[] datos = linea.Split(',');

            this.Legajo = long.Parse(datos[0]);
            this.ApellidoYNombre = datos[1];
            this.Categoria = datos[2];
        }

        public long Legajo { get; private set; }
        public string ApellidoYNombre { get; set; }
        public string Categoria { get; set; }
    }
}
