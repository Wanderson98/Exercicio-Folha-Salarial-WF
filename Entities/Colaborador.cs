using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula52Exercicio.Entities.Enums;

namespace Aula52Exercicio.Entities
{
    internal class Colaborador
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double SalarioLiquido { get; set; }
        public TipoContrato TipoDeContrato { get; set; }

        public Colaborador(string nome, double salarioBruto, TipoContrato tipoDeContrato)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            TipoDeContrato = tipoDeContrato;
        }

//        public override string ToString()
//        {
//;
//        }
    }
}
