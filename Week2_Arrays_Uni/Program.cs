namespace Week2_Arrays_Uni
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            RETO: SISTEMA DE CALIFICACIONES

            Objetivo: Desarrollar un programa que gestione las calificaciones de estudiantes y realice
            diferentes operaciones estadísticas.

            Requisitos:
            1. Crear un array para almacenar las calificaciones de 10 estudiantes (valores entre 0 y 100)
            2. Implementar las siguientes funcionalidades:
                  - Calcular el promedio de calificaciones
                  - Encontrar la calificación más alta y la más baja
                  - Calcular cuántos estudiantes aprobaron (calificación >= 60)
                  - Mostrar las calificaciones en orden ascendente
                  - Mostrar cuántos estudiantes obtuvieron calificaciones en los siguientes rangos:
                    * 0-59 (Reprobado)
                    * 60-69 (Suficiente)
                    * 70-79 (Bien)
                    * 80-89 (Notable)
                    * 90-100 (Excelente)

               Extra (opcional):
               - Permitir que el usuario ingrese las calificaciones
               - Implementar un menú para que el usuario elija la operación a realizar
               */

            int[] calificaciones = new int[10];

            // Ingreso de calificaciones por parte del usuario
            Console.WriteLine("Ingrese las calificaciones de 10 estudiantes (valores entre 0 y 100):");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                int nota;
                do
                {
                    Console.Write($"Calificación del estudiante {i + 1}: ");
                } while (!int.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100);

                calificaciones[i] = nota;
            }

            int opcion;
            do
            {
                Console.WriteLine("\n--- MENÚ DE OPCIONES ---");
                Console.WriteLine("1. Calcular promedio de calificaciones");
                Console.WriteLine("2. Calificación más alta y más baja");
                Console.WriteLine("3. Cantidad de estudiantes aprobados");
                Console.WriteLine("4. Mostrar calificaciones en orden ascendente");
                Console.WriteLine("5. Mostrar distribución por rangos");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        CalcularPromedio(calificaciones);
                        break;
                    case 2:
                        MostrarMayorYMenor(calificaciones);
                        break;
                    case 3:
                        ContarAprobados(calificaciones);
                        break;
                    case 4:
                        MostrarOrdenAscendente(calificaciones);
                        break;
                    case 5:
                        MostrarDistribucion(calificaciones);
                        break;
                    case 6:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

            } while (opcion != 6);


        }
        static void CalcularPromedio(int[] calificaciones)
        {
            double suma = 0;
            foreach (int calificacion in calificaciones)
            {
                suma += calificacion;
            }

            double promedio = suma / calificaciones.Length;
            Console.WriteLine($"Promedio general: {promedio:F2}");
        }

        static void MostrarMayorYMenor(int[] calificaciones)
        {
            int mayor = calificaciones[0];
            int menor = calificaciones[0];

            foreach (int calificacion in calificaciones)
            {
                if (calificacion > mayor) mayor = calificacion;
                if (calificacion < menor) menor = calificacion;
            }

            Console.WriteLine($"Calificación más alta: {mayor}");
            Console.WriteLine($"Calificación más baja: {menor}");
        }

        static void ContarAprobados(int[] calificaciones)
        {
            int aprobados = 0;

            foreach (int calificacion in calificaciones)
            {
                if (calificacion >= 60)
                    aprobados++;
            }

            Console.WriteLine($"Estudiantes aprobados: {aprobados} de {calificaciones.Length}");
        }

        static void MostrarOrdenAscendente(int[] calificaciones)
        {
            int[] ordenadas = (int[])calificaciones.Clone();
            Array.Sort(ordenadas);

            Console.WriteLine("Calificaciones ordenadas ascendentemente:");
            foreach (int calificacion in ordenadas)
            {
                Console.Write(calificacion + " ");
            }
            Console.WriteLine();
        }

        static void MostrarDistribucion(int[] calificaciones)
        {
            int reprobado = 0, suficiente = 0, bien = 0, notable = 0, excelente = 0;

            foreach (int calificacion in calificaciones)
            {
                if (calificacion <= 59)
                    reprobado++;
                else if (calificacion <= 69)
                    suficiente++;
                else if (calificacion <= 79)
                    bien++;
                else if (calificacion <= 89)
                    notable++;
                else
                    excelente++;
            }

            Console.WriteLine("Distribución de calificaciones:");
            Console.WriteLine($"0-59     (Reprobado): {reprobado}");
            Console.WriteLine($"60-69    (Suficiente): {suficiente}");
            Console.WriteLine($"70-79    (Bien): {bien}");
            Console.WriteLine($"80-89    (Notable): {notable}");
            Console.WriteLine($"90-100   (Excelente): {excelente}");
        }
    }


}
