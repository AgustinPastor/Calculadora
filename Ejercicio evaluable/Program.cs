using System.ComponentModel;

/*
Console.WriteLine("Iniciando la calculadora digital");
Console.WriteLine("Por favor, introduce tu nombre");
string? nombre = Console.ReadLine();
Console.WriteLine("Perfecto {0}, empecemos", nombre);
Console.WriteLine("Por favor, introduce el primer numero");
int numero1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Por favor, introduce el segundo numero");
int numero2 = int.Parse(Console.ReadLine()!);
*/
/*namespace calculadora
{
    class Programa
{
        public static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce el primer numero");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor introduce el segundo numero");
            int numero2 = int.Parse(Console.ReadLine());
            MetodoDividir(numero1, numero2);
            MetodoMultiplicar(numero1, numero2);

        }
        
        static void MetodoDividir(int numero1, int numero2){
            double division = (double)numero1 / numero2;
            Console.WriteLine("La division entre {0} / {1} es {2}", numero1, numero2, division);

        }   

        static void MetodoMultiplicar(int num1, int num2){
            double multiplicacion = (double)num1 * num2;
            Console.WriteLine("La multiplicacion de {0} * {1} es {2}", num1, num2, multiplicacion);




        }
    }




    
}
*/


namespace calculadora_prueba1
{
    class Programa
    { 
         public static void Main(string[] args)
        {
            int numero1, numero2;

            do
            {
                Console.WriteLine("Por favor introduce el primer numero (debe ser positivo o igual a 0):");
                numero1 = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Por favor introduce el segundo numero (debe ser positivo o igual a 0):");
                numero2 = int.Parse(Console.ReadLine());

                if (numero1 < 0 || numero2 <0)
                {
                Console.WriteLine("Ambos numeros deben ser positivos. Intentalo de nuevo.");

                }
        
            }while (numero1 <0 || numero2 <0);

            bool continuar = true;
            while (continuar)  
            {
                Console.WriteLine("---Menu de Operaciones---");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Selecciona una opcion (1-5):");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion) 
                {
                    case 1:
                        MetodoSumar(numero1, numero2);
                        break;
                    case 2:
                        MetodoRestar(numero1, numero2);
                        break;
                    case 3:
                        MetodoMultiplicar(numero1, numero2);
                        break;
                    case 4:
                        MetodoDividir(numero1, numero2);
                        break;
                    case 5:
                        continuar =false;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Por favor, selecciona una opcion entre 1 y 5.");
                        break;
                }
            }
        }
        static void MetodoSumar(int numero1, int numero2) 
        {
            int suma = numero1 + numero2;
            Console.WriteLine("La suma de {0} + {1} es {2}", numero1, numero2, suma);
        }
        static void MetodoRestar(int numero1, int numero2) 
        {
            int resta = numero1 - numero2;
            Console.WriteLine("La resta de {0} - {1} es {2}", numero1, numero2, resta);
        }
        static void MetodoMultiplicar(int numero1, int numero2) 
        {
            int multiplicacion = numero1 * numero2;
            Console.WriteLine("La multiplicacion de {0} * {1} es {2}", numero1, numero2, multiplicacion);
        }
        static void MetodoDividir(int numero1, int numero2) 
        {   
            if (numero2 != 0)   
            {
                double division = (double)numero1 / numero2;
                Console.WriteLine("La division de {0} / {1} es {2}", numero1, numero2, division);
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero.");
            }
        }
    }
}