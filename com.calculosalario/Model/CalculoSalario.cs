using System;
using System.Collections.Generic;
namespace com.calculosalario.Model{
    public class CalculoSalario{
        public string trabajador { get; set; }
        public int diasLaborados { get; set; }
        public int maximoDiasLaborados = 22;
        private const double bonoAdicional = 50000;
        private const double salarioDia = 35000;
        public double salarioCalculado { get; set; }

        public void registrarEmpleado(){
            Console.WriteLine("Digite el nombre del trabajador");
            trabajador = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite los días laborados");
            diasLaborados = Convert.ToInt16(Console.ReadLine());
        }
        public void calcularSalario(){
            if(diasLaborados>=0 && diasLaborados<=10){
                salarioCalculado = diasLaborados * salarioDia;

            }
            if(diasLaborados>10 && diasLaborados <=maximoDiasLaborados){
                salarioCalculado = (diasLaborados * salarioDia) + bonoAdicional;
            }
        }
    }
}
