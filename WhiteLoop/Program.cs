using System.Timers;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a los While Loops");
        //int contador = 0;
        //while (contador >= 0 && contador <= 10) {
        //    Console.WriteLine("El valor es : " + contador);
        //    contador++;

        //}
        //Console.WriteLine("Se acabó el bucle");

        // Tabla de multiplicar 
        int valorTabla;
        int resultado;
        int contadorTabla = 1;
        Console.WriteLine("Ingrese el valor de la tabla a multiplicar");
        valorTabla = Convert.ToInt32(Console.ReadLine());
        while (contadorTabla <= 12)
        {
            resultado = valorTabla * contadorTabla;
            Console.WriteLine("La tabla del numero : " + valorTabla+" es igual a "+valorTabla+" x "+ contadorTabla+" = "+resultado);

            contadorTabla++;
        }

        // Ejercicio Bucle anidado : Imprimir cuadrado de numeros del 1 al 5

        int fila=1;
        int columna;

        while (fila <= 5)
        {
            columna = 1;
            while (columna <= 5)
            {
                Console.Write(columna+" ");
                columna++;
            }
            Console.WriteLine();
            fila++;
        }

        // Ejercicio 2 Bucle
        
        int fila1 = 1;
        int columna1;

        while (fila1 <= 5)
        {
            columna1 = 1;
            while (columna1 <= fila1 )
            {
                Console.Write(columna1);
                columna1++;
            }
            Console.WriteLine();
            fila1++;
        }

        // Ejercicio 3 Bucle


        int filas = 5;
        int i = 1;

        while (i <= filas)
        {
            int j = 1;

            // Imprimir asteriscos
            while (j <= filas - i)
            {
                Console.Write("*");
                j++;
            }

            int k = 1;

            // Imprimir números del 1 hasta i
            while (k <= i)
            {
                Console.Write(k);
                k++;
            }

            Console.WriteLine();
            i++;
        }

        // Ejemplos de Do ... While
        int contadorDo = 1;
        do
        {
            Console.WriteLine(contadorDo);
            contadorDo++;
        }while (contadorDo <= 6);


        // Ejemplo de bucle  tipo For
       
        for (int iFor = 1; iFor <= 10; iFor++)
        {
            Console.WriteLine("El valor del bucle for es : " + iFor);
            for (int j = 0; j <= 1; j++)
            {
                Console.WriteLine(j+" ");
            }
        }

        // 2. Challenge 
        // el mismo ejemplo de bucle con For
        Console.WriteLine("==============");
        Console.WriteLine("  Challenge 2 ");
        Console.WriteLine("==============");


        // Bucle 1 
        for (int filaC = 1; filaC <= 5; filaC++)
        {
            for (int columnaC = 1; columnaC <= 5; columnaC++)
            {
                Console.Write(columnaC + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // Bucle 2
        for (int filaC2 = 1; filaC2 <= 5; filaC2++)
        {
            for (int columnaC2 = 1; columnaC2 <= filaC2; columnaC2++)
            {
                Console.Write(columnaC2);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

    }
}