using System;
using System.Collections.Generic;


namespace com.hotelbaru
{

    class Program
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Viaje> viajes = new List<Viaje>();
        
        static void Main(string[] args)
        {
            int opcionElegida = 0;
            Program hotelBaru = new Program();

            Console.Clear();
            hotelBaru.imprimirCreditos();
            Console.ForegroundColor = ConsoleColor.White;


            while (opcionElegida != 7){
                try{

                    opcionElegida = hotelBaru.imprimirMenuPrincipal();                        
                    hotelBaru.imprimirCreditos();

                    switch(opcionElegida){
                        case 1:
                            hotelBaru.imprimirTitulo("Su selección: 1. Registrar Cliente\n");
                            hotelBaru.registrarCliente();
                        break;
                        case 2:
                            hotelBaru.imprimirTitulo("Su selección: 2. Registrar Viaje\n");
                            hotelBaru.registrarViaje();
                        break;
                        case 3:
                            hotelBaru.imprimirTitulo("Su selección: 3. Imprimir directorio clientes\n");
                            hotelBaru.listarClientes();
                        break;
                        case 4:
                            hotelBaru.imprimirTitulo("Su selección: 4. Imprimir lista de viaje\n");
                            hotelBaru.listarViajes();
                        break;
                        case 5:
                            hotelBaru.imprimirTitulo("Su selección: 5. Consultar cliente (por identificación)\n");
                            hotelBaru.consultarClientePorIdentificacion();
                        break;
                        case 6:
                            hotelBaru.imprimirTitulo("Su selección: 6. Modificar el valor de un viaje (búsqueda por destino)\n");
                            hotelBaru.consultarViajePorDestino();
                        break;
                        case 7:
                            hotelBaru.imprimirSalida();  
                        break;
                        default:
                            hotelBaru.imprimirError("Error: Opción no existe, por favor seleccione un número válido indicado en las opciones");
                        break;
                    }
                }catch (Exception e){
                    e.ToString();
                    hotelBaru.imprimirError($"La opción seleccionada no es válida ");
                }
            }
        }

        public void consultarClientePorIdentificacion(){
            try{
                Console.WriteLine("Digite el número de documento del cliente a consultar");
                Int32 id = Convert.ToInt32(Console.ReadLine());
                try{
                    if(clientes.Contains(new Cliente {id=id })){
                        imprimirClientePorIdentificacion(id);
                    }else{
                        imprimirError("Error: El cliente con número de documento <<"+id+">> no fue encontrado");
                    }
                }catch(Exception e){
                    e.ToString();
                    imprimirError("Error: El cliente con número de documento <<"+id+">> no fue encontrado");
                }
            }catch(Exception e){
                e.ToString();
                imprimirError("Error: El número de documento debe ser un valor numérico");
            }
        }

        public void imprimirClientePorIdentificacion(Int32 id){

            Console.WriteLine("\nId \t\t\t\t Nombre \t\t\t\t Habitación " );
            foreach (Cliente cliente in clientes)
            {
                if(cliente.id == id){
                    Console.WriteLine(cliente);
                }
            }

        }

        public void registrarCliente(){
            Cliente cliente = new Cliente();
            bool clienteRegistrado = true;

            while(clienteRegistrado){
                Console.WriteLine("Digite la identificación del cliente");
                int id = Convert.ToInt16(Console.ReadLine());
                if(!clientes.Contains(new Cliente {id=id })){
                    cliente.solicitarDatos();
                    clientes.Add(new Cliente() {nombre=cliente.nombre, id=id, habitacion = cliente.habitacion});
                    clienteRegistrado = false;
                }else{
                    imprimirError("Error:El cliente con id <<"+id+">> ya existe");
                }
            }
        }
        public void listarClientes(){
            Console.WriteLine("{0} Clientes Registrados ", clientes.Count);

            Console.WriteLine("\nId \t\t\t\t Nombre \t\t\t\t Habitación " );
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

        }


        public void registrarViaje(){
            Viaje viaje = new Viaje();
            viaje.solicitarDatos();
            viajes.Add(new Viaje() {destino=viaje.destino, valor=viaje.valor});
        }

        public void listarViajes(){
            Console.WriteLine("{0} Viajes Registrados ", viajes.Count);

            Console.WriteLine("\nDestino \t\t\t\t Valor" );
            foreach (Viaje viaje in viajes)
            {
                Console.WriteLine(viaje);
            }
        } 

        public void consultarViajePorDestino(){
            Console.WriteLine("Digite el nombre del destino a consultar");
            String destino = Convert.ToString(Console.ReadLine());
            try{
                Viaje viaje = viajes.Find(x => x.destino.Contains(destino));
                if(viaje.destino == destino){
                    double valorAnterior = viaje.valor;
                    Console.WriteLine("Digite el valor a modificar del destino <<{0}>>", destino);
                    viaje.valor = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Al destino <<{0}>> se ha modificado el valor <<{0}>> por el nuevo valor <<{0}>>", destino,valorAnterior, viaje.valor);

                    //imprimirViajePorDestino(destino);
                }else{
                    imprimirError("Error: El destino <<"+destino+">> no fue encontrado");
                }

            }catch(Exception e){
                e.ToString();
                imprimirError("Error: El destino <<"+destino+">> no fue encontrado");
            }
        }

        
        public void imprimirViajePorDestino(String destino){

            Console.WriteLine("\nDestino \t\t\t\t Valor" );
            foreach (Viaje viaje in viajes)
            {
                if(viaje.destino == destino){
                    Console.WriteLine(viajes);
                }
            }

        }

        public void imprimirTitulo(String titulo){
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine(titulo);
            Console.WriteLine("--------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void imprimirError(String mensajeError){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensajeError);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void imprimirCreditos(){
            Console.Write("\n****************************************************************************");
            Console.Write("\n,--.  ,--.         ,--.         ,--.    ,-----.                          ");
            Console.Write("\n|  '--'  | ,---. ,-'  '-. ,---. |  |    |  |) /_  ,--,--.,--.--.,--.,--. ");
            Console.Write("\n|  .--.  || .-. |'-.  .-'| .-. :|  |    |  .-.  \' ,-.  ||  .--'|  ||  | ");
            Console.Write("\n|  |  |  |' '-' '  |  |  |  --. |  |    |  '--' /\' '-'  ||  |   '  ''  ' ");
            Console.Write("\n`--'  `--' `---'   `--'   `----'`--'    `------'  `--`--'`--'    `----'  ");
            Console.Write("\n                                                 Por: Johana Katherine Ávila");
            Console.Write("\n****************************************************************************");
            Console.Write("\n\nPrograma que permite administrar clientes y viajes del Hotel Baru\n\n");
        }

        public void imprimirSalida(){
            Console.Clear();
            Console.Write("\n ,----.                        ,--.                                                                  ,---.              ,--.                              ");
            Console.Write("\n'  .-./   ,--.--. ,--,--. ,---.`--' ,--,--. ,---.      ,---.  ,---. ,--.--.     ,---. ,--.--. ,---. /  .-' ,---. ,--.--.`--',--.--.,--,--,  ,---.  ,---.  ");
            Console.Write("\n|  | .---.|  .--'' ,-.  || .--',--.' ,-.  |(  .-'     | .-. || .-. ||  .--'    | .-. ||  .--'| .-. :|  `-,| .-. :|  .--',--.|  .--'|      \'| .-. |(  .-'  ");
            Console.Write("\n'  '--'  ||  |   \' '-'  |\' `--.|  |\' '-'  |.-'  `)    | '-' '' '-' '|  |       | '-' '|  |   \'   --.|  .-'\'   --.|  |   |  ||  |   |  ||  |' '-' '.-'  `) ");
            Console.Write("\n`------' `--'    `--`--' `---'`--' `--`--'`----'      |  |-'  `---' `--'       |  |-' `--'    `----'`--'   `----'`--'   `--'`--'   `--''--' `---' `----'  ");
            Console.Write("\n                                                       `--'                     `--'                                                                       \n");
        }
        public int imprimirMenuPrincipal(){
            Console.Write("\nSeleccione una opción: ");
            Console.Write("\n[1] Registrar Cliente ");
            Console.Write("\n[2] Registrar Viaje ");
            Console.Write("\n[3] Imprimir directorio clientes");
            Console.Write("\n[4] Imprimir lista de viajes");
            Console.Write("\n[5] Consultar cliente (por identificación)");
            Console.Write("\n[6] Modificar el valor de un viaje (búsqueda por destino)");
            Console.Write("\n[7] Salir \n");
            return Convert.ToInt16(Console.ReadLine());
        }

    }
        
}