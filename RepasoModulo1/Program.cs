namespace RepasoModulo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fila1 = 1;
            int columna1;

            while (fila1 <= 5)
            {
                columna1 = 1;
                while (columna1 <= fila1)
                {
                    Console.Write(columna1);
                    columna1++;
                }
                Console.WriteLine();
                fila1++;
            }

        }
    }
}
