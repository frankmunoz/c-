using System;

namespace com.calculosalario
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionElegida = 0;
            Model.Mensajes mensajes = new Model.Mensajes();
            Model.Seguridad seguridad = new Model.Seguridad();
            Model.CalculoSalario calculoSalario = new Model.CalculoSalario();

            if(seguridad.solicitarCredenciales()){

                while (opcionElegida != 2){
                    try{
                        mensajes.imprimirCreditos();
                        opcionElegida = mensajes.imprimirMenuPrincipal();                        

                        switch(opcionElegida){
                            case 1:
                                try{
                                    calculoSalario.registrarEmpleado();
                                    if(calculoSalario.diasLaborados>=0 && calculoSalario.diasLaborados<=calculoSalario.maximoDiasLaborados){
                                        calculoSalario.calcularSalario();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("El valor calculado del salario para el empleado <<{0}>> es de COP {1:C2} por concepto de {2} días laborados", calculoSalario.trabajador, calculoSalario.salarioCalculado, calculoSalario.diasLaborados);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Presiona una tecla para continuar");
                                        Console.ReadLine();
                                    }else{
                                        mensajes.imprimirError("Error: Número de días laborados no válido");
                                    }
                                }catch (Exception e){
                                    e.ToString();
                                    mensajes.imprimirError($"La opción seleccionada no es válida");
                                }
                            break;
                            case 2:
                                mensajes.imprimirSalida();  
                            break;
                            default:
                                mensajes.imprimirError("Error: Opción no existe, por favor seleccione un número válido indicado en las opciones");
                            break;
                        }
                    }catch (Exception e){
                        e.ToString();
                        mensajes.imprimirError($"La opción seleccionada no es válida ");
                    }
                }
            }
            mensajes.imprimirSalida();  

        }
    }
}
