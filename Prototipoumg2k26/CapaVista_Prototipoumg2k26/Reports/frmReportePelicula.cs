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
using Microsoft.Reporting.WinForms;

namespace CapaVista_Prototipoumg2k26.Reports
{
    public partial class frmReportePelicula : Form
    {
        private ModeloPelicula Pelicula = new ModeloPelicula();
        public frmReportePelicula()
        {
            InitializeComponent();
        }

        private void frmReportePelicula_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("ReportePeliculas", Pelicula.GetAll());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Prototipoumg2k26.Reports.ReportPeliculas.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
