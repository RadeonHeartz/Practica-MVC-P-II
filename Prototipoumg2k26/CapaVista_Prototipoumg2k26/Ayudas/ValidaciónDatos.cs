using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CapaVista_Prototipoumg2k26.Ayudas
{
    public class ValidaciónDatos
    {
        private ValidationContext contexto;
        private List<ValidationResult> resultados;
        private bool valido;
        private string Mensaje;
        public ValidaciónDatos(object instancia)
        {
            contexto = new ValidationContext(instancia);
            resultados = new List<ValidationResult>();
            valido = Validator.TryValidateObject(instancia, contexto, resultados, true);
        }
        public bool validar()
        {
            if (valido == false)
            {
                foreach (ValidationResult item in resultados)
                {
                    Mensaje += item.ErrorMessage + "\n";
                }
                System.Windows.Forms.MessageBox.Show(Mensaje);
            }
            return valido;
        }
    }
    
}
