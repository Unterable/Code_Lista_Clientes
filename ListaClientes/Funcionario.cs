using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaClientes
{
    public class Funcionario : Cliente
    {
        public string Cargo { get; private set; }
        public double Salario { get; private set; }
    }
}
