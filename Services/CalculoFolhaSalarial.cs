using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula52Exercicio.Entities;
using Aula52Exercicio.Entities.Enums;
namespace Aula52Exercicio.Services
{
    internal class CalculoFolhaSalarial
    {

        public static double CalculoClt(double salarioBruto)
        {
            double vt = salarioBruto * 0.06;
            double inss = 0;
            if (salarioBruto <= 1212)
            {
                inss = salarioBruto * 0.075;

            }
            else if (salarioBruto <= 2427.35)
            {
                inss = salarioBruto * 0.09;
            }
            else if (salarioBruto <= 3641.03)
            {
                inss = salarioBruto * 0.12;
            }
            else
            {
                inss = salarioBruto * 0.14;
            }

            return salarioBruto - inss - vt;
        }

        public static double CalculoPJ(double salarioBruto)
        {
            return salarioBruto -= salarioBruto * 0.06;
        }

        public static double CalculoFreeLancer(double salarioBruto, double valorProjeto)
        {
            return salarioBruto += valorProjeto * 0.085;
        }
    }
}