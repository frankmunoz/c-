using System;
using System.Collections.Generic;

namespace com.hotelbaru{
    class Cliente : IEquatable<Cliente>
    {
        public Int32 id { get; set; }
        public string nombre { get; set; }
        public string habitacion { get; set; }

        public void solicitarDatos(){
            Console.WriteLine("Digite el nombre del cliente");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite el número de habitación del cliente");
            habitacion = Convert.ToString(Console.ReadLine());
        }

        public override string ToString()
        {
            return string.Format(id + " \t\t\t\t " + nombre + " \t\t\t\t " + habitacion);            
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Cliente objAsCliente = obj as Cliente;
            if (objAsCliente == null) return false;
            else return Equals(objAsCliente);
        }
        public override Int32 GetHashCode()
        {
            return id;
        }
        public bool Equals(Cliente other)
        {
            if (other == null) return false;
            return (this.id.Equals(other.id));
        }
    }
}