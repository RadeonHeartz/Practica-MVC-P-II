using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Prototipoumg2k26.Entidades
{
    public class Peliculas
    {
        public int id_pelicula { get; set; }
        public int id_clasificacion { get; set; }
        public int id_estado_pelicula { get; set; }
        public string titulo_pelicula { get; set; }
        public int duracion_pelicula { get; set; }
        public string director_pelicula { get; set; }
        public string descripcion_pelicula { get; set; }
        public string trailer_pelicula { get; set; }
        public DateTime fecha_estreno { get; set; }
    }
}
