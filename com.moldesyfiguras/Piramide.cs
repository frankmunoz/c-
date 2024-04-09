using System;

namespace com.moldesyfiguras
{
    class Piramide : FiguraGeometrica
    {
        protected double longitud { get; set; }
        protected double ancho { get; set; }

        public Piramide(){
            this.nombre = "Pirámide";
        }

        private double calcularPerimetroBase(){
            return (2 * this.longitud) + (2 * this.ancho);
        }

        private double calcularAreaBase(){
            return this.longitud * this.ancho;
        }

        public override void solicitarDatos(){
            Console.Write("\nDigite la longitud de la base de la piramide \n");
            this.longitud = Convert.ToSingle(Console.ReadLine());
            Console.Write("\nDigite el ancho de la base de la piramide \n");
            this.ancho = Convert.ToSingle(Console.ReadLine());
            Console.Write("\nDigite la altura de la piramide \n");
            this.altura = Convert.ToSingle(Console.ReadLine());
        }

        public override void calcularArea(){
            this.area =  0.5 * calcularPerimetroBase() * this.altura + calcularAreaBase();
        }

        public override void calcularVolumen(){
            this.volumen = (this.longitud * this.ancho * this.altura) / 3;
        }

        public override void imprimirValores(){
            Console.Write("Valores ingresados para la figura " + this.nombre + "\n");
            Console.Write("Altura: " + this.altura + this.unidadMedida + "\n");
            Console.Write("Longitud: " + this.longitud + this.unidadMedida + "\n");
            Console.Write("Ancho: " + this.ancho + this.unidadMedida + "\n");
        }

    }
}