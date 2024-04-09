using System;

namespace com.moldesyfiguras
{
    class Cilindro : FiguraGeometrica
    {
        private double radio { get; set; }
        private double pi = 3.141592 ;
 
        public Cilindro(){
            this.nombre = "Cilindro";
        }

        public override void solicitarDatos(){
            Console.Write("\nDigite la altura del cilindro \n");
            this.altura = Convert.ToSingle(Console.ReadLine());
            Console.Write("\nDigite el radio del cilindro \n");
            this.radio = Convert.ToSingle(Console.ReadLine());
        }

        public override void calcularArea(){
            this.area =  2 * pi * this.radio * (this.altura + this.radio);
        }

        public override void calcularVolumen(){
            this.volumen = pi * (this.radio * this.radio) * this.altura;
        }

        public override void imprimirValores(){
            Console.Write("Valores ingresados para la figura " + this.nombre + "\n");
            Console.Write("Altura: " + this.altura + this.unidadMedida + "\n");
            Console.Write("Radio: " + this.radio + this.unidadMedida + "\n");
        }    
    }
}