using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Prototipoumg2k26.Contratos
{
    public interface IRepositorioGenerico<Entity> where Entity : class
    {
        int Agregar(Entity entity); //Agregar datos
        int Editar(Entity entity); //Editar datos
        int Borrar(Entity entity); //Borrar datos
        IEnumerable<Entity> GetAll(); //Listar los datos
    }
}
