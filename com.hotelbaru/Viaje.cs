using System;
using System.Collections.Generic;

namespace com.hotelbaru{
    class Viaje : IEquatable<Viaje>
    {
        public Int32 id { get; set; }
        public string destino { get; set; }
        public double valor { get; set; }

        public void solicitarDatos(){
            Console.WriteLine("Digite el destino del viaje");
            destino = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite el valor del viaje");
            valor = Convert.ToDouble(Console.ReadLine());            
        }


        public override string ToString()
        {
            return string.Format(destino + " \t\t\t\t " + valor);            
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Viaje objAsViaje = obj as Viaje;
            if (objAsViaje == null) return false;
            else return Equals(objAsViaje);
        }
        public override Int32 GetHashCode()
        {
            return id;
        }

        public bool Equals(Viaje other)
        {
            if (other == null) return false;
            return (this.valor.Equals(other.valor));
        }
    }
}