namespace RepasoModulo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Con While
            Console.WriteLine("Con While");
            int fila = 1;
            int columna;

            while (fila <= 5)
            {
                columna = 1;
                while (columna <= fila)
                {
                    Console.Write(columna);
                    columna++;
                }
                Console.WriteLine();
                fila++;
            }


            // Con For

            Console.WriteLine("Con For");
            int fila1, columna1;

            // Bucle para las filas
            for (fila1 = 1; fila1 <= 5; fila1++)
            {
                // Bucle para las columnas
                for (columna1 = 1; columna1 <= fila1; columna1++)
                {
                    Console.Write(columna1);
                }
                // Salto de línea después de cada fila
                Console.WriteLine();
            }




            // Patron 2
            //         *
            //        * *
            //       * * *
            //      * * * *
            //     * * * * *

            int filasP = 5;  // Número de filas que queremos imprimir

            for (int i = 1; i <= filasP; i++)
            {
                // Imprimir los espacios antes de los asteriscos
                for (int j = 1; j <= filasP - i; j++)
                {
                    Console.Write(" ");  // Espacios antes de los asteriscos
                }

                // Imprimir los asteriscos con espacio entre ellos
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");  // Asterisco con espacio
                }

                // Nueva línea después de cada fila
                Console.WriteLine();
            }

            //Tarea 4 : El reto de buscar duplicados en un arreglo
            // Contar los Duplicados
            // Arreglo con los valores
            int[] numeros = { 44, 44, 32, 32, 35 };

            // Recorremos el arreglo con foreach para encontrar duplicados
            int duplicados = 0;

            // Usamos un arreglo para marcar los números ya verificados
            bool[] yaContado = new bool[numeros.Length];

            // Recorremos el arreglo con foreach
            foreach (int numero in numeros)
            {
                // Evitamos contar los números ya marcados
                int contador = 0;

                // Comparamos el número actual con los siguientes números en el arreglo
                foreach (int comparar in numeros)
                {
                    if (numero == comparar)
                    {
                        contador++; // Si encontramos una repetición, incrementamos el contador
                    }
                }

                // Si el número tiene más de 1 aparición, lo consideramos un duplicado
                if (contador > 1)
                {
                    // Contamos solo el primer duplicado
                    if (!yaContado[Array.IndexOf(numeros, numero)])
                    {
                        Console.WriteLine($"El número {numero} se repite.");
                        yaContado[Array.IndexOf(numeros, numero)] = true; // Marcamos como contado
                        duplicados++;
                    }
                }
            }

            // Mostrar el total de duplicados
            Console.WriteLine($"Total de números duplicados: {duplicados}");
        }
    }
}
