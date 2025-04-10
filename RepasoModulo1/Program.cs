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

            int filasP = 5;  // Número de filas que queremos imprimir

            for (int i = 1; i <= filasP; i++)
            {
                // Imprimir los espacios antes de los asteriscos
                for (int j = 1; j <= filasP - i; j++)
                {
                    Console.Write("-");  // Espacios antes de los asteriscos
                }

                // Imprimir los asteriscos con espacio entre ellos
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");  // Asterisco con espacio
                }

                // Nueva línea después de cada fila
                Console.WriteLine();
            }

        }
    }
}
