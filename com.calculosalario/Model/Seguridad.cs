using System;
using System.Threading;

namespace com.calculosalario.Model{
    public class Seguridad{
        public bool solicitarCredenciales(){
            int clave = 0;
            const int claveSecreta = 123;
            Model.Mensajes mensajes = new Model.Mensajes();
            Console.Clear();
            while (claveSecreta != clave){
                try{
                    Console.Write("\nDigite su clave: ");
                    clave = Convert.ToInt16(Console.ReadLine());

                    if(claveSecreta == clave)
                        return true;
                    
                    Console.Write("\nCredenciales no válidas ");
                    return false;
                }catch (Exception e){
                    e.ToString();
                    mensajes.imprimirError("Valor no válido ");
                }
            }
            return false;
        }
            
    }    
}
