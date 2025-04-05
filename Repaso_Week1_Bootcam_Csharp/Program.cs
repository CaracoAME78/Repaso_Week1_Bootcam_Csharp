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

        // Comprobar si un numero es par o Impar
        Console.WriteLine("=================================");
        Console.WriteLine("   COMPROBAR PAR o IMPAR    ");
        Console.WriteLine("=================================");
        Console.WriteLine("Ingrese el primer número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());


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

    }
}