using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Prototipoumg2k26.Contratos;
using CapaModelo_Prototipoumg2k26.Entidades;
using CapaModelo_Prototipoumg2k26.Repositorios;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace CapaControlador_prototipoumg2k26
{
    public class ModeloPelicula
    {
        private int _id_pelicula;
        private int _id_clasificacion;
        private int _id_estado_pelicula;
        private string _titulo_pelicula;
        private int _duracion_pelicula;
        private string _director_pelicula;
        private string _descripcion_pelicula;
        private string _trailer_pelicula;
        private DateTime _fecha_estreno;
        private IRepositorioPeliculas RepositorioPeliculas;

        public EstadoEntidad Estado { private get; set; }
        private List<ModeloPelicula> _ListaPelicula;

        public int id_pelicula { get => _id_pelicula; set => _id_pelicula = value; }

        [Required(ErrorMessage = "El campo 'Clasificación' es obligatorio.")]
        public int id_clasificacion { get => _id_clasificacion; set => _id_clasificacion = value; }

  
        public int id_estado_pelicula { get => _id_estado_pelicula; set => _id_estado_pelicula = value; }

        [Required(ErrorMessage = "El campo 'Título de la película' es obligatorio.")]
        public string titulo_pelicula { get => _titulo_pelicula; set => _titulo_pelicula = value; }

        [Required(ErrorMessage = "El campo 'duración' es obligatorio.")]
        public int duracion_pelicula { get => _duracion_pelicula; set => _duracion_pelicula = value; }

        [Required(ErrorMessage = "El campo 'director' es obligatorio.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El campo 'director' solo puede contener letras y espacios.")]
        [StringLength(maximumLength: 100, MinimumLength = 2, ErrorMessage = "El campo 'director' debe tener entre 2 y 100 caracteres.")]
        public string director_pelicula { get => _director_pelicula; set => _director_pelicula = value; }

        [Required(ErrorMessage = "El campo 'descripción' es obligatorio.")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "El campo 'descripción' solo puede contener letras, números y espacios.")]
        [StringLength(maximumLength: 200, MinimumLength = 10, ErrorMessage = "El campo 'descripción' debe tener entre 10 y 200 caracteres.")]
        public string descripcion_pelicula { get => _descripcion_pelicula; set => _descripcion_pelicula = value; }

        [Required(ErrorMessage = "El campo 'trailer' es obligatorio.")]
        public string trailer_pelicula { get => _trailer_pelicula; set => _trailer_pelicula = value; }
        public DateTime fecha_estreno { get => _fecha_estreno; set => _fecha_estreno = value; }

        public ModeloPelicula()
        {
            RepositorioPeliculas = new RepositorioPeliculas();
        }
        public string GrabarCambios()
        {
            string mensaje = null;
            try
            {
                var modeloDatosPeliculas = new Peliculas();
                modeloDatosPeliculas.id_pelicula = _id_pelicula;
                modeloDatosPeliculas.id_clasificacion = _id_clasificacion;
                modeloDatosPeliculas.id_estado_pelicula = _id_estado_pelicula;
                modeloDatosPeliculas.titulo_pelicula = _titulo_pelicula;
                modeloDatosPeliculas.duracion_pelicula = _duracion_pelicula;
                modeloDatosPeliculas.director_pelicula = _director_pelicula;
                modeloDatosPeliculas.descripcion_pelicula = _descripcion_pelicula;
                modeloDatosPeliculas.trailer_pelicula = _trailer_pelicula;
                modeloDatosPeliculas.fecha_estreno = _fecha_estreno;
                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        RepositorioPeliculas.Agregar(modeloDatosPeliculas);
                        mensaje = "Registro agregado correctamente.";
                        break;
                    case EstadoEntidad.Deleted:
                        RepositorioPeliculas.Borrar(modeloDatosPeliculas);
                        mensaje = "Registro eliminado correctamente.";
                        break;
                    case EstadoEntidad.Modified:
                        RepositorioPeliculas.Editar(modeloDatosPeliculas);
                        mensaje = "Registro modificado correctamente.";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            return mensaje;
        }
        public List<ModeloPelicula> GetAll()
        {
            var ModeloDatosPeliculas = RepositorioPeliculas.GetAll();
            _ListaPelicula = new List<ModeloPelicula>();
            foreach (Peliculas item in ModeloDatosPeliculas)
            {
                var fecha_estreno = item.fecha_estreno;
                _ListaPelicula.Add(new ModeloPelicula
                {
                    _id_pelicula = item.id_pelicula,
                    _id_clasificacion = item.id_clasificacion,
                    _id_estado_pelicula = item.id_estado_pelicula,
                    _titulo_pelicula = item.titulo_pelicula,
                    _duracion_pelicula = item.duracion_pelicula,
                    _director_pelicula = item.director_pelicula,
                    _descripcion_pelicula = item.descripcion_pelicula,
                    _trailer_pelicula = item.trailer_pelicula,
                    _fecha_estreno = item.fecha_estreno
                });
               
            }
            return _ListaPelicula;
        }
        public IEnumerable<ModeloPelicula> GetById(string filter)
        {
            return _ListaPelicula.FindAll(e => e.id_pelicula.ToString().Contains(filter) || e.id_clasificacion.ToString().Contains(filter) || e.id_estado_pelicula.ToString().Contains(filter)); 
        }   
    }
}
