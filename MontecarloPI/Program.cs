using System;

namespace MontecarloPI
{
    class Program
    {
        static void Main()
        {
            // http://paginas.fisica.uson.mx/laura.yeomans/dex2/pi.pdf
            // https://www.i-ciencias.com/pregunta/31476/como-saber-si-un-punto-esta-dentro-de-un-circulo

            Random aleatorio = new Random();
            int cantPuntoCuadrado = 100000000;
            int cantPuntoCirculo = 0;           
            double x = 0.0;
            double y = 0.0;

            for (int i = 0; i < cantPuntoCuadrado; i++)
            {
                x = aleatorio.NextDouble();
                y = aleatorio.NextDouble();

                if ((Math.Sqrt(x * x + y * y) <= 1.0))                
                    cantPuntoCirculo++;   
            }
            Console.WriteLine("Aproximación de PI es: " + (Double)(4 * cantPuntoCirculo) / cantPuntoCuadrado);      
        }       
    }
}
