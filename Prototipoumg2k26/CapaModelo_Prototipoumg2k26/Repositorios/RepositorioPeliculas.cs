using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Prototipoumg2k26.Contratos;
using CapaModelo_Prototipoumg2k26.Entidades;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CapaModelo_Prototipoumg2k26.Repositorios
{
    public class RepositorioPeliculas : RepositorioMaestro, IRepositorioPeliculas
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        public RepositorioPeliculas()
        {
            selectAll = "SELECT * FROM tbl_pelicula";
            insert = "INSERT INTO tbl_pelicula VALUES (NULL, ?, ?, ?, ?, ?, ?, ?, ?)";
            update = "UPDATE tbl_pelicula SET id_clasificacion = ?, id_estado_pelicula = ?, titulo_pelicula = ?, duracion_pelicula = ?, director_pelicula = ?, descripcion_pelicula = ?, trailer_pelicula = ?, fecha_estreno = ? WHERE id_pelicula = ?";
            delete = "DELETE FROM tbl_pelicula WHERE id_pelicula = ?";
        }

        public int Agregar(Peliculas entidad)
        {
            var _parametros = new List<OdbcParameter>();
            {
                _parametros.Add(new OdbcParameter("p_id_clasificacion", entidad.id_clasificacion));
                _parametros.Add(new OdbcParameter("p_id_estado_pelicula", entidad.id_estado_pelicula));
                _parametros.Add(new OdbcParameter("p_titulo_pelicula", entidad.titulo_pelicula));
                _parametros.Add(new OdbcParameter("p_duracion_pelicula", entidad.duracion_pelicula));
                _parametros.Add(new OdbcParameter("p_director_pelicula", entidad.director_pelicula));
                _parametros.Add(new OdbcParameter("p_descripcion_pelicula", entidad.descripcion_pelicula));
                _parametros.Add(new OdbcParameter("p_trailer_pelicula", entidad.trailer_pelicula));
                _parametros.Add(new OdbcParameter("p_fecha_estreno", entidad.fecha_estreno));
            }
            return EjecucionNonQuery(insert, _parametros, CommandType.Text);
        }
        public int Borrar(Peliculas entidad)
        {
            var _parametros = new List<OdbcParameter>();
            {
                _parametros.Add(new OdbcParameter("p_id_pelicula", entidad.id_pelicula));
            }
            return EjecucionNonQuery(delete, _parametros, CommandType.Text);
        }
        public int Editar(Peliculas entidad)
        {
            var _parametros = new List<OdbcParameter>();
            {
                _parametros.Add(new OdbcParameter("p_id_pelicula", entidad.id_pelicula));
                _parametros.Add(new OdbcParameter("p_id_clasificacion", entidad.id_clasificacion));
                _parametros.Add(new OdbcParameter("p_id_estado_pelicula", entidad.id_estado_pelicula));
                _parametros.Add(new OdbcParameter("p_titulo_pelicula", entidad.titulo_pelicula));
                _parametros.Add(new OdbcParameter("p_duracion_pelicula", entidad.duracion_pelicula));
                _parametros.Add(new OdbcParameter("p_director_pelicula", entidad.director_pelicula));
                _parametros.Add(new OdbcParameter("p_descripcion_pelicula", entidad.descripcion_pelicula));
                _parametros.Add(new OdbcParameter("p_trailer_pelicula", entidad.trailer_pelicula));
                _parametros.Add(new OdbcParameter("p_fecha_estreno", entidad.fecha_estreno));
            }
            return EjecucionNonQuery(update, _parametros, CommandType.Text);
        }
        public IEnumerable<Peliculas> GetAll()
        {
            var _listaPeliculas = new List<Peliculas>();
            var TblTabla = EjecucionConsulta(selectAll, CommandType.Text);
            foreach (DataRow row in TblTabla.Rows)
            {
                var pelicula = new Peliculas();
                pelicula.id_pelicula = Convert.ToInt32(row [0]);
                pelicula.id_clasificacion = Convert.ToInt32(row[1]);
                pelicula.id_estado_pelicula = Convert.ToInt32(row[2]);
                pelicula.titulo_pelicula = row[3].ToString();
                pelicula.duracion_pelicula = Convert.ToInt32(row[4]);
                pelicula.director_pelicula = row[5].ToString();
                pelicula.descripcion_pelicula = row[6].ToString();
                pelicula.trailer_pelicula = row[7].ToString();
                pelicula.fecha_estreno = Convert.ToDateTime(row[8]);

                _listaPeliculas.Add(pelicula);
            }
            TblTabla.Clear();
            TblTabla = null;
            return _listaPeliculas;

        }
    }
}
