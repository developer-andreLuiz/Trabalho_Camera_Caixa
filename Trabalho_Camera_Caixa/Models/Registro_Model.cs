using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Camera_Caixa.Models
{
    class Registro_Model
    {
        public string codigo { get; set; }
        public string nome { get; set; }
        public string hora { get; set; }
        public string funcionario { get; set; }
        public Registro_Model()
        {
           
        }
        public Registro_Model(string Codigo, string Nome, string Hora, string Funcionario)
        {
            codigo = Codigo;
            nome = Nome;
            hora = Hora;
            funcionario = Funcionario;
        }
    }
}
