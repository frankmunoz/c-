using System;

namespace com.calculosalario.Model{
    public class Mensajes{
        public void imprimirCreditos(){
            Console.Clear();
            Console.Write("\n******************************************************************");
            Console.Write("\n   ___      _            _         __       _            _        ");
            Console.Write("\n  / __\\__ _| | ___ _   _| | ___   / _\\ __ _| | __ _ _ __(_) ___   ");
            Console.Write("\n / /  / _` | |/ __| | | | |/ _ \\  \\ \\ / _` | |/ _` | '__| |/ _ \\  ");
            Console.Write("\n/ /__| (_| | | (__| |_| | | (_) | _\\ \\ (_| | | (_| | |  | | (_) | ");
            Console.Write("\n\\____/\\__,_|_|\\___|\\__,_|_|\\___/  \\__/\\__,_|_|\\__,_|_|  |_|\\___/  ");
            Console.Write("\n                                                                  ");
            Console.Write("\n                                  Autor: Johana Katherine Ávila");
            Console.Write("\n                                     Curso: Estructura de datos");
            Console.Write("\n*******************************************************************");
            Console.Write("\n\nPrograma que permite calcular el salario de un empleado \n\n");
        }            

        public int imprimirMenuPrincipal(){
            Console.Write("\nSeleccione una opción: ");
            Console.Write("\n[1] Calcular Salario ");
            Console.Write("\n[2] Salir \n");
            return Convert.ToInt16(Console.ReadLine());
        }

        public void imprimirSalida(){
            Console.Clear();
            Console.Write("\n GRACIAS \n");
        }
        public void imprimirError(String mensajeError){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensajeError);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

    }
}
