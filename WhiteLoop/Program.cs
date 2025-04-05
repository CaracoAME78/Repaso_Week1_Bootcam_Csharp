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
    }
}