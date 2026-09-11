using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_ComboI;

namespace Capa_Vista_ComboI
{
    public partial class ComboI : UserControl
    {
        public ComboI()
        {
            InitializeComponent();
        }
        Modelo_ComboI controlador = new Modelo_ComboI();
        public void llenarCombo(string table, string campo1, string campo2)
        {
            var dtTable = controlador.enviarDatos(table, campo1, campo2);

            cboPrueba.DataSource = dtTable;
            cboPrueba.ValueMember = "id_pelicula";
            cboPrueba.DisplayMember = "titulo_pelicula";
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach(DataRow row in dtTable.Rows){
                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }
            cboPrueba.AutoCompleteCustomSource = coleccion;
            cboPrueba.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPrueba.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
