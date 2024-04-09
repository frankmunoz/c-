using System;

namespace com.moldesyfiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar="S";
            bool error;
            int figuraElegida, unidadElegida;
            Program moldesYFiguras = new Program();

            while (continuar != "N" && continuar != "n" && (continuar == "S" || continuar == "s") ){
                figuraElegida = 0;
                unidadElegida = 0;
                moldesYFiguras.imprimirCreditos();
                FiguraGeometrica figura = new Cono();

                while (figuraElegida <= 0 || figuraElegida>=4){
                    try{
                        error = false;

                        figuraElegida = moldesYFiguras.imprimirMenuFiguras();                        

                        switch(figuraElegida){
                            case 1:
                                Console.WriteLine("Su selección: 1. Cono\n");
                                figura =  new Cono(); 
                            break;
                            case 2:
                                Console.WriteLine("Su selección: 2. Cilindro\n");
                                figura = new Cilindro();
                            break;
                            case 3:
                                Console.WriteLine("Su selección: 3. Pirámide recta\n");
                                figura = new Piramide();
                            break;
                            default:
                                Console.WriteLine("Opción no existe, por favor seleccione un número de la lista de figuras");
                                error = true;
                            break;
                        }
                    }catch (Exception e){
                        Console.WriteLine($"La figura seleccionada no está en la lista de figuras" + e.ToString());
                    }
                }
                while (unidadElegida <= 0 || unidadElegida>=4){
                    try{
                        error = false;

                        unidadElegida = moldesYFiguras.imprimirMenuUnidadMedida();

                        switch(unidadElegida){
                            case 1:
                                figura.unidadMedida = "mm"; 
                            break;
                            case 2:
                                figura.unidadMedida = "cm"; 
                            break;
                            case 3:
                                figura.unidadMedida = "m"; 
                            break;
                            default:
                                Console.WriteLine("Opción no existe, por favor seleccione una unidad de medida la lista de unidades");
                                error = true;
                            break;
                        }
                        
                        if(!error){
                            figura.solicitarDatos();
                            figura.calcularArea();
                            figura.calcularVolumen();

                            moldesYFiguras.imprimirCreditos();
                            figura.imprimirArea();
                            figura.imprimirVolumen();
                            figura.imprimirValores();
                        }

                    }catch (Exception e){
                        Console.WriteLine($"La figura seleccionada no está en la lista de figuras" + e.ToString());
                    }
                }
                
                Console.Write("¿Desea continuar con otra figura? presione S, presione cualquier tecla para finalizar: ");
                continuar = Console.ReadLine();
            } 
            moldesYFiguras.imprimirSalida();  
        }

        public void imprimirCreditos(){
            Console.Clear();
            Console.Write("\n****************************************************************************");
            Console.Write("\n___  ___      _     _                    ______ _                           ");
            Console.Write("\n|  \\/  |     | |   | |                   |  ___(_)                          ");
            Console.Write("\n| .  . | ___ | | __| | ___  ___   _   _  | |_   _  __ _ _   _ _ __ __ _ ___ ");
            Console.Write("\n| |\\/| |/ _ \\| |/ _` |/ _ \\/ __| | | | | |  _| | |/ _` | | | | '__/ _` / __|");
            Console.Write("\n| |  | | (_) | | (_| |  __/\\__ \\ | |_| | | |   | | (_| | |_| | | | (_| \\__ \\");
            Console.Write("\n\\_|  |_/\\___/|_|\\__,_|\\___||___/  \\__, | \\_|   |_|\\__, |\\__,_|_|  \\__,_|___/");
            Console.Write("\n                                   __/ |           __/ |                    ");
            Console.Write("\n                                  |___/           |___/                     ");
            Console.Write("\n                                                 Por: Johana Katherine Ávila");
            Console.Write("\n****************************************************************************");
            Console.Write("\n\nPrograma que permite calcular la cantidad de material a solicitar al área de pedidos y el tamaño y área de la figura para el área de empaque\n\n");
        }

        public void imprimirSalida(){
            Console.Clear();
            Console.Write("\n )_)  _   _ _)_  _      _   _  _   _  _)_  _        ");
            Console.Write("\n( (  (_( (  (_  (_(    )_) )  (_) ) ) (_  (_) o o o ");
            Console.Write("\n         _)           (                             \n");
        }
        public int imprimirMenuFiguras(){
            Console.Write("\nSeleccione el número de la figura para calcular el tamaño: ");
            Console.Write("\n[1] Cono ");
            Console.Write("\n[2] Cilindro ");
            Console.Write("\n[3] Pirámide recta \n");
            return Convert.ToInt16(Console.ReadLine());
        }
        public int imprimirMenuUnidadMedida(){
            Console.Write("\nSeleccione la unidad de medida: ");
            Console.Write("\n[1] Milímetros ");
            Console.Write("\n[2] Centímetros ");
            Console.Write("\n[3] Metros \n");
            return Convert.ToInt16(Console.ReadLine());
        }
    }
        
}
