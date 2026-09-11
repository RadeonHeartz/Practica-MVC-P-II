using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_ComboI.Repositorios
{
    public class Repositorio_ComboInteligente : Repositorio
    {
        public DataTable obtenerDatos(string table, string campo1, string campo2)
        {
            string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + table + ";";

            OdbcCommand command = new OdbcCommand(sql, ObtenerConexion());
            OdbcDataAdapter adapter = new OdbcDataAdapter(command);
            DataTable dtDatos = new DataTable();
            adapter.Fill(dtDatos);
            return dtDatos;
        }
    }
}
