using System;

namespace com.moldesyfiguras
{
    abstract class FiguraGeometrica
    {
        public string nombre { get; set; }
        public string unidadMedida { get; set; }
        public double area { get; set; }
        public double volumen { get; set; }
        protected double altura { get; set; }        
        public virtual void calcularArea(){}
        public virtual void calcularVolumen(){}
        public virtual void solicitarDatos(){}
        public virtual void imprimirValores(){}

        public void imprimirArea(){
            Console.Write("La figura " + this.nombre +  " tiene un área de " + this.area + this.unidadMedida + "^2\n");

        }
        public void imprimirVolumen(){
            Console.Write("La figura " + this.nombre +  " tiene un volúmen de " + this.volumen + this.unidadMedida + "^3\n");
        }

    }
}
