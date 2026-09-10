using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Prototipoumg2k26.Repositorios
{
    public abstract class RepositorioMaestro : Repositorio
    {
        private DataTable dtTablaDatos; //Establecer las tablas de dataos de las consultas
        public int EjecucionNonQuery(string _comandoTexto, List<OdbcParameter> _parametros, CommandType _comandoTipo)
        {
            using (var conexion = ObtenerConexion()) 
            {
                conexion.Open();
                using (var ocComando = new OdbcCommand())
                {
                    ocComando.Connection = conexion;
                    ocComando.CommandText = _comandoTexto;
                    ocComando.CommandType = _comandoTipo;
                    ocComando.Parameters.AddRange(_parametros.ToArray()); //Agregar la colección de parámetros al comando
                    return ocComando.ExecuteNonQuery(); //Ejecutar el comando y devolver el número de filas afectadas
                }
            }
        }
        public DataTable EjecucionConsulta(string _comandoTexto, CommandType _comandoTipo)
        {
            dtTablaDatos = new DataTable();
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var ocComando = new OdbcCommand())
                {
                    ocComando.Connection = conexion;
                    ocComando.CommandText = _comandoTexto;
                    ocComando.CommandType = _comandoTipo;
                    using (var reader = ocComando.ExecuteReader())
                        dtTablaDatos.Load(reader); //Cargar los datos del reader en el DataTable)
                    
                }
                return dtTablaDatos; //Retorno de la tabla de datos
            }
        }
    }
}
