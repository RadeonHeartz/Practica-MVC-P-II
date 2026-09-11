using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_ComboI.Repositorios;

namespace Capa_Controlador_ComboI
{
    public class Modelo_ComboI
    {
        Repositorio_ComboInteligente sentencias = new Repositorio_ComboInteligente();

        public DataTable enviarDatos(string table, string campo1, string campo2)
        {
            var dtTabla = sentencias.obtenerDatos(table, campo1, campo2);
            return dtTabla;
        }
    }
}
