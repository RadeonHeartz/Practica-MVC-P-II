using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_prototipoumg2k26;

namespace CapaVista_Prototipoumg2k26
{
    public partial class FormularioPeliculas : Form
    {
        private ModeloPelicula pelicula = new ModeloPelicula();
        public FormularioPeliculas()
        {
            InitializeComponent();
            p_ingresoDatos.Enabled = false;
            CargarDatos();
        }

        private void FrmPeliculas_Load(object sender, EventArgs e)
        {
            listaPeliculas();
        }
        private void listaPeliculas()
        {
            try
            {
                dgv_peliculas.DataSource = pelicula.GetAll();
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgv_peliculas.DataSource = pelicula.GetById(txt_buscar.Text);
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            dgv_peliculas.DataSource = pelicula.GetById(txt_buscar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_clasificacion.Text, out int clasificacion))
            {
                MessageBox.Show("El campo 'Clasificación' debe contener un número.");
                return;
            }

            if (!int.TryParse(txt_estado.Text, out int estado))
            {
                MessageBox.Show("El campo 'Estado de la película' debe contener un número.");
                return;
            }

            if (!int.TryParse(txt_duracion.Text, out int duracion))
            {
                MessageBox.Show("El campo 'Duración' debe contener un número.");
                return;
            }

            pelicula.id_clasificacion = clasificacion;
            pelicula.id_estado_pelicula = estado;
            pelicula.titulo_pelicula = txt_titulo.Text;
            pelicula.duracion_pelicula = duracion;
            pelicula.director_pelicula = txt_director.Text;
            pelicula.descripcion_pelicula = txt_descripcion.Text;
            pelicula.trailer_pelicula = txt_trailer.Text;
            pelicula.fecha_estreno = dtp_estreno.Value;

            bool valido = new Ayudas.ValidaciónDatos(pelicula).validar();

            if (valido)
            {
                string resultado = pelicula.GrabarCambios();
                MessageBox.Show(resultado);
                listaPeliculas();
                Reinicio();
            }
        }
        private void Reinicio()
        {
            p_ingresoDatos.Enabled = false;
            txt_buscar.Clear();
            txt_clasificacion.Clear();
            txt_descripcion.Clear();
            txt_director.Clear();
            txt_descripcion.Clear();
            txt_duracion.Clear();
            txt_estado.Clear();
            txt_titulo.Clear();
            txt_trailer.Clear();
            dtp_estreno.Value = DateTime.Today;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            p_ingresoDatos.Enabled = true;
            pelicula.Estado = EstadoEntidad.Added;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgv_peliculas.SelectedRows.Count > 0)
            {
                p_ingresoDatos.Enabled = true;
                pelicula.Estado = EstadoEntidad.Modified;
                pelicula.id_pelicula = Convert.ToInt32(dgv_peliculas.CurrentRow.Cells[0].Value);
                txt_clasificacion.Text = dgv_peliculas.CurrentRow.Cells[1].Value.ToString();
                txt_estado.Text = dgv_peliculas.CurrentRow.Cells[2].Value.ToString();
                txt_titulo.Text = dgv_peliculas.CurrentRow.Cells[3].Value.ToString();
                txt_duracion.Text = dgv_peliculas.CurrentRow.Cells[4].Value.ToString();
                txt_director.Text = dgv_peliculas.CurrentRow.Cells[5].Value.ToString();
                txt_descripcion.Text = dgv_peliculas.CurrentRow.Cells[6].Value.ToString();
                txt_trailer.Text = dgv_peliculas.CurrentRow.Cells[7].Value.ToString();
                dtp_estreno.Value = Convert.ToDateTime(dgv_peliculas.CurrentRow.Cells[8].Value);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if(dgv_peliculas.SelectedRows.Count > 0)
            {
                pelicula.Estado = EstadoEntidad.Deleted;
                pelicula.id_pelicula = Convert.ToInt32(dgv_peliculas.CurrentRow.Cells[0].Value);
                string resultado = pelicula.GrabarCambios();
                MessageBox.Show(resultado);
                listaPeliculas();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }
        void CargarDatos()
        {
            comboI1.llenarCombo("tbl_pelicula", "id_pelicula", "titulo_pelicula");

        }
    }
}
