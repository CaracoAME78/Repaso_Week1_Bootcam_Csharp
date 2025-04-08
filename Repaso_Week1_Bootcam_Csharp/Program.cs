internal class Program
{
    private static void Main(string[] args)
    {
        int edad = 1;
        double numeroDecimal = 10.00;
        string nombre = "Andre"; // referencia
        char caracter = '1';
        bool esMayordeEdad = true;

        if (edad > 18)
        {
            Console.WriteLine("Es Mayor de Edad");
        }
        else
        {
            Console.WriteLine("No es Mayor de Edad");
        }

        Console.WriteLine("=================");
        Console.WriteLine("Dias de la Semana");
        string diaSemana = "Lunes";
        switch (diaSemana) {
            case "Lunes":
                Console.WriteLine("El dia es lunes.");
                break;
            case "Martes":
                Console.WriteLine("El dia es Martes.");
                break;
            default: 
                Console.WriteLine("No es un dia de semana.");
                break;
        }

       

        // Establecer el maryor de tres numeros ingresados

        Console.WriteLine("=================================");
        Console.WriteLine("   ESTABLECER EL NUMERO MAYOR    ");
        Console.WriteLine("=================================");
        Console.WriteLine("Ingrese el primer número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número:");
        int numero3 = Convert.ToInt32(Console.ReadLine());

        int mayor;

        if (numero1 >= numero2 && numero1 >= numero3)
        {
            mayor = numero1;
        }
        else if (numero2 >= numero1 && numero2 >= numero3)
        {
            mayor = numero2;
        }
        else
        {
            mayor = numero3;
        }

        Console.WriteLine("El número mayor es:"+ mayor);


        // Calculo de Áreas 
        int opcion;
        double area;

        Console.WriteLine("=================================");
        Console.WriteLine("   CÁLCULO DE ÁREAS              ");
        Console.WriteLine("=================================");
        Console.WriteLine("1. Área del Círculo");
        Console.WriteLine("2. Área del Rectangulo");
        Console.Write("Seleccione una opción (1 o 2): ");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.Write("Ingrese el radio del círculo: ");
                double radio = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(radio, 2);
                Console.WriteLine($"El área del círculo es: {area:F2}");
                break;

            case 2:
                Console.Write("Ingrese el largo del rectangulo: ");
                double lado = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el ancho del rectangulo: ");
                double ancho = double.Parse(Console.ReadLine());

                area = lado*ancho;
                Console.WriteLine($"El área del rectangulo es: {area:F2}");
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();

        Console.WriteLine();

        // Llamada de una funcion
        int x, y;
        x = 10;
        y = 20;
        int suma = add(x, y);
        Console.WriteLine(suma);




    }
    public static int add(int a, int b)
    {
        int result = a + b;
        return result;
    }
}